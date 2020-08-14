using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PECDriveV2
{
    public partial class PECDeviceUtility : Form
    {
        public PECDeviceUtility()
        {
            InitializeComponent();
        }

        // To go to the compression windows/form 
        private void compressForm_Click(object sender, EventArgs e)
        {
            PECDeviceUtility.ActiveForm.Visible = false;
            Compression frm = new Compression();
            frm.Show();
        }

        // To go to the encryption windows/form
        private void encryptForm_Click(object sender, EventArgs e)
        {
            PECDeviceUtility.ActiveForm.Visible = false;
            Encryption frm = new Encryption();
            frm.Show();
        }

        // To go to the decryption windows/form
        private void decryptForm_Click(object sender, EventArgs e)
        {
            PECDeviceUtility.ActiveForm.Visible = false;
            Decryption frm = new Decryption();
            frm.Show();
        }

        // To go the decompression windows/form
        private void decompressForm_Click(object sender, EventArgs e)
        {
            PECDeviceUtility.ActiveForm.Visible = false;
            Decompression frm = new Decompression();
            frm.Show();
        }

        // To terminate and exit the application/form/windows
        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
