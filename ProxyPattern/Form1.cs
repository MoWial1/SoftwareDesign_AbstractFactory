using ProxyPattern.Files;
using System;
using System.Windows.Forms;

namespace ProxyPattern
{
    public partial class Form1 : Form
    {
        private IFile fileProxy = null;
        private string selectedPath = "";

        public Form1()
        {
            InitializeComponent();
            txtContent.ReadOnly = true;
            txtContent.WordWrap = false;
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedPath = openFileDialog1.FileName;
                fileProxy = new FileProxy(selectedPath);
                lblPath.Text = $"Файл обрано: {selectedPath}";
                txtContent.Text = "[Файл ще не відкрито]";
            }
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            if (fileProxy == null)
            {
                MessageBox.Show("Спочатку виберіть файл.");
                return;
            }

            try
            {
                txtContent.Text = fileProxy.Read();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }
    }
}
