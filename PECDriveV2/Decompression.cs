using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Threading;
using System.Windows.Forms.VisualStyles;

namespace PECDriveV2
{
    public partial class Decompression : Form
    {
        public Decompression()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // Select File
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "All Files|*.*", ValidateNames = true, Multiselect = true })
            {
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtFilePath.Text = ofd.FileName;
                }
                else
                {
                    MessageBox.Show("No File Chosen!");
                }
            }
        }

        private void btnDecompress_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog1.FileName;
                DialogResult result2 = folderBrowserDialog1.ShowDialog();
                if (result2 == DialogResult.OK)
                {
                    try
                    {
                        ZipFile.ExtractToDirectory(openFileDialog1.FileName, folderBrowserDialog1.SelectedPath + DateTime.Now.ToString("mmss"));
                        MessageBox.Show("ZIP file extracted successfully!");
                    }
                    catch(IOException)
                    {
                        var exists = File.Exists(txtFilePath.Text);
                        MessageBox.Show("File already exists!");
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Decompression.ActiveForm.Visible = false;
            PECDeviceUtility frm = new PECDeviceUtility();
            frm.Show();
        }
    }
}
