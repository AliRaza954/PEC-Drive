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

namespace PECDriveV2
{
    public partial class Compression : Form
    {
        public Compression()
        {
            InitializeComponent();
        }

        //public static string file = null;
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

        private void btnCompress_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilePath.Text))
            {
                MessageBox.Show("Please select your filename.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFilePath.Focus();
                return;
            }
            MessageBox.Show("Compressed successfully!");
         
            string fileName = txtFilePath.Text;
            //Zip file & update process bar
            Thread thread = new Thread(t =>
            {
                using (Ionic.Zip.ZipFile zip = new Ionic.Zip.ZipFile())
                {
                    FileInfo fi = new FileInfo(fileName);
                    zip.AddFile(fileName);
                    System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(fileName);
                    //zip.SaveProgress += Zip_SaveFileProgress;
                    zip.Save(string.Format("{0}/{1}" + DateTime.Now.ToString(".mmss") + ".zip", di.Parent.FullName, fi.Name));
                }
            })
            { IsBackground = true };
            thread.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Compression.ActiveForm.Visible = false;
            PECDeviceUtility frm = new PECDeviceUtility();
            frm.Show();
        }
    }
}
