using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translator
{
    public partial class FilePreview : Form
    {
        private readonly string _filePath;
        public FilePreview()
        {
            InitializeComponent();
        }

        public FilePreview(string filePath)
        {
            InitializeComponent();

            _filePath = filePath;
        }

        private void FilePreview_Load(object sender, EventArgs e)
        {
            var file = new FileInfo(_filePath);
            if (!file.Exists)
            {
                MessageBox.Show($"'{file.FullName}' does not exist", "File preview", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else
            {
                try
                {
                    var data = File.ReadAllText(file.FullName);
                    richTextBox1.Text = data;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "File preview", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
