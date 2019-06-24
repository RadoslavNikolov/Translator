using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Security;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translator
{
    public partial class Form1 : Form
    {
        private delegate void SafeCallDelegate();
        private const string SourceDir = @"D:\Test";
        private delegate void SetTextCallback(string text);

        public Form1()
        {
            InitializeComponent();

            InitializeControls();
        }

        private void InitializeControls()
        {
            openFileDialog1.Filter = "Resource files (*.resx)|*.resx";
            openFileDialog1.Multiselect = true;

            LoadDirContent(SourceDir);

            gridSelectedFiles.ClearSelection();
            gridProcessedFiles.ClearSelection();
        }

        private void SourceDirContentChanged(object sender, FileSystemEventArgs e)
        {
            BtnProcessedFilesClear_Click(null,null);
            BtnRefresh_Click(null, null);
        }

        private void LoadDirContent(string dirPath)
        {
            var dir = new DirectoryInfo(dirPath);
            if (dir.Exists)
            {
                var files = dir.GetFiles("*.*", SearchOption.AllDirectories);
                if (files.Any())
                {
                    gridProcessedFiles.ClearSelection();
                    processedFilesTable.BeginInit();
                    processedFilesTable.Rows.Clear();

                    foreach (FileInfo file in files)
                    {
                        var newRow = processedFilesTable.NewRow();
                        newRow["fileName"] = file.FullName.Trim();
                        processedFilesTable.Rows.Add(newRow);
                    }

                    processedFilesTable.EndInit();
                }
            }
        }

        private void BtnSelecFiles_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    gridSelectedFiles.ClearSelection();
                    selectedFilesTable.BeginInit();
                    selectedFilesTable.Rows.Clear();

                    var selectedFiles = openFileDialog1.FileNames;
                    foreach (var selectedFile in selectedFiles)
                    {
                        var newRow = selectedFilesTable.NewRow();
                        newRow["fileName"] = selectedFile.Trim();
                        selectedFilesTable.Rows.Add(newRow);
                    }
                    
                    selectedFilesTable.EndInit();
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void BtnTranslate_Click(object sender, EventArgs e)
        {

            if (gridSelectedFiles.SelectedRows.Count == 0)
            {
                MessageBox.Show("No files selected!", "Translation process", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var processor = new FIleProcessor(System.Configuration.ConfigurationManager.AppSettings["AzureTextTranslationServiceEndpoint"],
                System.Configuration.ConfigurationManager.AppSettings["AzureTextTranslationServiceKey"]);
            foreach (DataGridViewRow selectedRow in gridSelectedFiles.SelectedRows)
            {
                var sourceFilePath = selectedRow.Cells[0].Value.ToString();
                var dirInfo = new DirectoryInfo(SourceDir);

                AppendLine($"Processing file: '{sourceFilePath}' ...");
                Task<FileInfo> task = new Task<FileInfo>(() => processor.ProcessFile(sourceFilePath, dirInfo));
                task.ContinueWith(ExceptionHandler, TaskContinuationOptions.OnlyOnFaulted);
                task.ContinueWith(FileTranslateProcessComplete, TaskContinuationOptions.OnlyOnRanToCompletion);
                task.Start();
            }
        }

        public void ExceptionHandler(Task<FileInfo> task)
        {
            var exceptions = task.Exception?.InnerExceptions;
            if (exceptions == null) return;

            foreach (Exception e in exceptions)
            {
                AppendLine(e.Message ?? "");
            }
        }

        public void FileTranslateProcessComplete(Task<FileInfo> task)
        {
            if (!processedFilesTable.Rows.Cast<DataRow>().Any(x => x["fileName"].Equals(task.Result.FullName)))
            {
                var newRow = processedFilesTable.NewRow();
                newRow["fileName"] = task.Result.FullName;
                processedFilesTable.Rows.Add(newRow);
            }

            RedrawProcessedFilesGrid();
            AppendLine($"File '{task.Result.FullName}' has been successfully processed");
        }

        public void RedrawProcessedFilesGrid()
        {
            if (gridProcessedFiles.InvokeRequired)
            {
                SafeCallDelegate d = RedrawProcessedFilesGrid;
                Invoke(d);
            }else
            {
                gridProcessedFiles.Refresh();
            }
        }

        public void AppendLine(string value)
        {
            if (txbInfo.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(AppendLine);
                Invoke(d, value);
            }else
            {
                if (txbInfo.Text.Length == 0)
                {
                    txbInfo.Text = value;
                }
                else
                {
                    txbInfo.AppendText($"{Environment.NewLine}{value}");
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            selectedFilesTable.Rows.Clear();
        }

        private void BtnProcessedFilesClear_Click(object sender, EventArgs e)
        {
            processedFilesTable.Rows.Clear();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadDirContent(SourceDir);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void BtnProcessedPreview_Click(object sender, EventArgs e)
        {
            if (gridProcessedFiles.SelectedRows.Count == 0)
            {
                MessageBox.Show("No file selected!", "Translation process", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            var filepath = gridProcessedFiles.SelectedRows[0].Cells[0].Value.ToString();
            using (var form = new FilePreview(filepath))
            {
                form.ShowDialog();
            }
        }

        private void BtnPlainTextClear_Click(object sender, EventArgs e)
        {
            txbPlainTextSource.Text = "";
            txbPlainTextResult.Text = "";
        }

        private void BtnPlantextTranslate_Click(object sender, EventArgs e)
        {
            var sourceText = txbPlainTextSource.Text;
            if (string.IsNullOrWhiteSpace(sourceText))
            {
                MessageBox.Show("Nothing to translate", "Translation process", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var textProcessor = new TextProcessor(System.Configuration.ConfigurationManager.AppSettings["AzureTextTranslationServiceEndpoint"],
                System.Configuration.ConfigurationManager.AppSettings["AzureTextTranslationServiceKey"]);
            var result = textProcessor.Translate(sourceText);
            txbPlainTextResult.Text = result;
        }

        private void BtnSelectedFilePreview_Click(object sender, EventArgs e)
        {
            if (gridSelectedFiles.SelectedRows.Count == 0)
            {
                MessageBox.Show("No file selected!", "Translation process", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            var filepath = gridSelectedFiles.SelectedRows[0].Cells[0].Value.ToString();
            using (var form = new FilePreview(filepath))
            {
                form.ShowDialog();
            }
        }
    }
}
