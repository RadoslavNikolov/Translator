namespace Translator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txbInfo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnProcessedFilesClear = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.gridProcessedFiles = new System.Windows.Forms.DataGridView();
            this.processedFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet1 = new System.Data.DataSet();
            this.selectedFilesTable = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.processedFilesTable = new System.Data.DataTable();
            this.dataColumn2 = new System.Data.DataColumn();
            this.btnProcessedPreview = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSelectedFilesClear = new System.Windows.Forms.Button();
            this.gridSelectedFiles = new System.Windows.Forms.DataGridView();
            this.fileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSelectedFilePreview = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSelectFiles = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txbPlainTextResult = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnPlainTextClear = new System.Windows.Forms.Button();
            this.btnPlantextTranslate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txbPlainTextSource = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProcessedFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedFilesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processedFilesTable)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSelectedFiles)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selected files:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Processed files:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(871, 587);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(863, 561);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tekerik Report Server Resx";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txbInfo);
            this.panel5.Location = new System.Drawing.Point(6, 455);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(846, 100);
            this.panel5.TabIndex = 9;
            // 
            // txbInfo
            // 
            this.txbInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbInfo.Location = new System.Drawing.Point(0, 0);
            this.txbInfo.Multiline = true;
            this.txbInfo.Name = "txbInfo";
            this.txbInfo.Size = new System.Drawing.Size(846, 100);
            this.txbInfo.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnProcessedFilesClear);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.gridProcessedFiles);
            this.panel2.Controls.Add(this.btnProcessedPreview);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(6, 235);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(849, 202);
            this.panel2.TabIndex = 7;
            // 
            // btnProcessedFilesClear
            // 
            this.btnProcessedFilesClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProcessedFilesClear.Image = global::Translator.Properties.Resources.close;
            this.btnProcessedFilesClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcessedFilesClear.Location = new System.Drawing.Point(724, 123);
            this.btnProcessedFilesClear.Name = "btnProcessedFilesClear";
            this.btnProcessedFilesClear.Size = new System.Drawing.Size(122, 41);
            this.btnProcessedFilesClear.TabIndex = 9;
            this.btnProcessedFilesClear.Text = "Clear";
            this.btnProcessedFilesClear.UseVisualStyleBackColor = true;
            this.btnProcessedFilesClear.Click += new System.EventHandler(this.BtnProcessedFilesClear_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefresh.Image = global::Translator.Properties.Resources.Preview;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(724, 76);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(122, 41);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // gridProcessedFiles
            // 
            this.gridProcessedFiles.AllowUserToAddRows = false;
            this.gridProcessedFiles.AllowUserToDeleteRows = false;
            this.gridProcessedFiles.AutoGenerateColumns = false;
            this.gridProcessedFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProcessedFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.processedFileName});
            this.gridProcessedFiles.DataMember = "ProcessedFIles";
            this.gridProcessedFiles.DataSource = this.dataSet1;
            this.gridProcessedFiles.Location = new System.Drawing.Point(8, 29);
            this.gridProcessedFiles.Name = "gridProcessedFiles";
            this.gridProcessedFiles.ReadOnly = true;
            this.gridProcessedFiles.RowHeadersVisible = false;
            this.gridProcessedFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProcessedFiles.Size = new System.Drawing.Size(700, 170);
            this.gridProcessedFiles.TabIndex = 8;
            // 
            // processedFileName
            // 
            this.processedFileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.processedFileName.DataPropertyName = "fileName";
            this.processedFileName.HeaderText = "File name";
            this.processedFileName.Name = "processedFileName";
            this.processedFileName.ReadOnly = true;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.selectedFilesTable,
            this.processedFilesTable});
            // 
            // selectedFilesTable
            // 
            this.selectedFilesTable.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1});
            this.selectedFilesTable.TableName = "SelectedFiles";
            // 
            // dataColumn1
            // 
            this.dataColumn1.AllowDBNull = false;
            this.dataColumn1.Caption = "File Name";
            this.dataColumn1.ColumnName = "fileName";
            // 
            // processedFilesTable
            // 
            this.processedFilesTable.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn2});
            this.processedFilesTable.TableName = "ProcessedFIles";
            // 
            // dataColumn2
            // 
            this.dataColumn2.AllowDBNull = false;
            this.dataColumn2.Caption = "File name";
            this.dataColumn2.ColumnName = "fileName";
            // 
            // btnProcessedPreview
            // 
            this.btnProcessedPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProcessedPreview.Image = global::Translator.Properties.Resources.Preview;
            this.btnProcessedPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcessedPreview.Location = new System.Drawing.Point(724, 29);
            this.btnProcessedPreview.Name = "btnProcessedPreview";
            this.btnProcessedPreview.Size = new System.Drawing.Size(122, 41);
            this.btnProcessedPreview.TabIndex = 7;
            this.btnProcessedPreview.Text = "Preview";
            this.btnProcessedPreview.UseVisualStyleBackColor = true;
            this.btnProcessedPreview.Click += new System.EventHandler(this.BtnProcessedPreview_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSelectedFilesClear);
            this.panel1.Controls.Add(this.gridSelectedFiles);
            this.panel1.Controls.Add(this.btnSelectedFilePreview);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnSelectFiles);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 220);
            this.panel1.TabIndex = 6;
            // 
            // btnSelectedFilesClear
            // 
            this.btnSelectedFilesClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectedFilesClear.Image = global::Translator.Properties.Resources.close;
            this.btnSelectedFilesClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectedFilesClear.Location = new System.Drawing.Point(725, 166);
            this.btnSelectedFilesClear.Name = "btnSelectedFilesClear";
            this.btnSelectedFilesClear.Size = new System.Drawing.Size(122, 41);
            this.btnSelectedFilesClear.TabIndex = 8;
            this.btnSelectedFilesClear.Text = "Clear";
            this.btnSelectedFilesClear.UseVisualStyleBackColor = true;
            this.btnSelectedFilesClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // gridSelectedFiles
            // 
            this.gridSelectedFiles.AllowUserToAddRows = false;
            this.gridSelectedFiles.AllowUserToDeleteRows = false;
            this.gridSelectedFiles.AutoGenerateColumns = false;
            this.gridSelectedFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSelectedFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileNameDataGridViewTextBoxColumn});
            this.gridSelectedFiles.DataMember = "SelectedFiles";
            this.gridSelectedFiles.DataSource = this.dataSet1;
            this.gridSelectedFiles.Location = new System.Drawing.Point(9, 25);
            this.gridSelectedFiles.Name = "gridSelectedFiles";
            this.gridSelectedFiles.ReadOnly = true;
            this.gridSelectedFiles.RowHeadersVisible = false;
            this.gridSelectedFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSelectedFiles.Size = new System.Drawing.Size(700, 183);
            this.gridSelectedFiles.TabIndex = 7;
            // 
            // fileNameDataGridViewTextBoxColumn
            // 
            this.fileNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fileNameDataGridViewTextBoxColumn.DataPropertyName = "fileName";
            this.fileNameDataGridViewTextBoxColumn.HeaderText = "File name";
            this.fileNameDataGridViewTextBoxColumn.Name = "fileNameDataGridViewTextBoxColumn";
            this.fileNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnSelectedFilePreview
            // 
            this.btnSelectedFilePreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectedFilePreview.Image = global::Translator.Properties.Resources.Preview;
            this.btnSelectedFilePreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectedFilePreview.Location = new System.Drawing.Point(725, 72);
            this.btnSelectedFilePreview.Name = "btnSelectedFilePreview";
            this.btnSelectedFilePreview.Size = new System.Drawing.Size(122, 41);
            this.btnSelectedFilePreview.TabIndex = 6;
            this.btnSelectedFilePreview.Text = "Preview";
            this.btnSelectedFilePreview.UseVisualStyleBackColor = true;
            this.btnSelectedFilePreview.Click += new System.EventHandler(this.BtnSelectedFilePreview_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Image = global::Translator.Properties.Resources.translate31;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(725, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Translate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnTranslate_Click);
            // 
            // btnSelectFiles
            // 
            this.btnSelectFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectFiles.Image = global::Translator.Properties.Resources.fileopen;
            this.btnSelectFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectFiles.Location = new System.Drawing.Point(725, 25);
            this.btnSelectFiles.Name = "btnSelectFiles";
            this.btnSelectFiles.Size = new System.Drawing.Size(122, 41);
            this.btnSelectFiles.TabIndex = 4;
            this.btnSelectFiles.Text = "Select files";
            this.btnSelectFiles.UseVisualStyleBackColor = true;
            this.btnSelectFiles.Click += new System.EventHandler(this.BtnSelecFiles_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(863, 561);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Plain text";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txbPlainTextResult);
            this.panel3.Location = new System.Drawing.Point(7, 275);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(849, 280);
            this.panel3.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result:";
            // 
            // txbPlainTextResult
            // 
            this.txbPlainTextResult.Location = new System.Drawing.Point(5, 29);
            this.txbPlainTextResult.Multiline = true;
            this.txbPlainTextResult.Name = "txbPlainTextResult";
            this.txbPlainTextResult.Size = new System.Drawing.Size(841, 248);
            this.txbPlainTextResult.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnPlainTextClear);
            this.panel4.Controls.Add(this.btnPlantextTranslate);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txbPlainTextSource);
            this.panel4.Location = new System.Drawing.Point(6, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(850, 262);
            this.panel4.TabIndex = 8;
            // 
            // btnPlainTextClear
            // 
            this.btnPlainTextClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlainTextClear.Image = global::Translator.Properties.Resources.close;
            this.btnPlainTextClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlainTextClear.Location = new System.Drawing.Point(714, 72);
            this.btnPlainTextClear.Name = "btnPlainTextClear";
            this.btnPlainTextClear.Size = new System.Drawing.Size(122, 41);
            this.btnPlainTextClear.TabIndex = 10;
            this.btnPlainTextClear.Text = "Clear";
            this.btnPlainTextClear.UseVisualStyleBackColor = true;
            this.btnPlainTextClear.Click += new System.EventHandler(this.BtnPlainTextClear_Click);
            // 
            // btnPlantextTranslate
            // 
            this.btnPlantextTranslate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlantextTranslate.Image = global::Translator.Properties.Resources.translate31;
            this.btnPlantextTranslate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlantextTranslate.Location = new System.Drawing.Point(714, 25);
            this.btnPlantextTranslate.Name = "btnPlantextTranslate";
            this.btnPlantextTranslate.Size = new System.Drawing.Size(122, 41);
            this.btnPlantextTranslate.TabIndex = 9;
            this.btnPlantextTranslate.Text = "Translate";
            this.btnPlantextTranslate.UseVisualStyleBackColor = true;
            this.btnPlantextTranslate.Click += new System.EventHandler(this.BtnPlantextTranslate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Source:";
            // 
            // txbPlainTextSource
            // 
            this.txbPlainTextSource.Location = new System.Drawing.Point(6, 25);
            this.txbPlainTextSource.Multiline = true;
            this.txbPlainTextSource.Name = "txbPlainTextSource";
            this.txbPlainTextSource.Size = new System.Drawing.Size(702, 234);
            this.txbPlainTextSource.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tabControl1);
            this.flowLayoutPanel1.Controls.Add(this.statusStrip1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(874, 687);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 593);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(55, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(38, 17);
            this.toolStripStatusLabel1.Text = "status";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 687);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Translator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProcessedFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedFilesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processedFilesTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSelectedFiles)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbPlainTextResult;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbPlainTextSource;
        private System.Windows.Forms.Button btnSelectedFilePreview;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSelectFiles;
        private System.Windows.Forms.Button btnProcessedPreview;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable selectedFilesTable;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataTable processedFilesTable;
        private System.Data.DataColumn dataColumn2;
        private System.Windows.Forms.DataGridView gridProcessedFiles;
        private System.Windows.Forms.DataGridView gridSelectedFiles;
        private System.Windows.Forms.Button btnSelectedFilesClear;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txbInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn processedFileName;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnProcessedFilesClear;
        private System.Windows.Forms.Button btnPlainTextClear;
        private System.Windows.Forms.Button btnPlantextTranslate;
    }
}

