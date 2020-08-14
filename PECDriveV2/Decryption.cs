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
using System.Security.Cryptography;
namespace PECDriveV2
{
    public partial class Decryption : Form
    {
        public Decryption()
        {
            InitializeComponent();
        }


		public byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
		{
			byte[] decryptedBytes = null;
			byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

			using (MemoryStream ms = new MemoryStream())
			{
				using (RijndaelManaged AES = new RijndaelManaged())
				{
					AES.KeySize = 256;
					AES.BlockSize = 128;

					var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
					AES.Key = key.GetBytes(AES.KeySize / 8);
					AES.IV = key.GetBytes(AES.BlockSize / 8);

					AES.Mode = CipherMode.CBC;

					using (var cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
					{
						cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
						cs.Close();
					}
					decryptedBytes = ms.ToArray();
				}
			}

			return decryptedBytes;
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

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
			if (txtFilePath.Text != null)
			{
				try
				{
					string password = enterPassword.ToString();

					byte[] bytesToBeDecrypted = File.ReadAllBytes(txtFilePath.Text);
					byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
					passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

					byte[] bytesDecrypted = AES_Decrypt(bytesToBeDecrypted, passwordBytes);

					string fileEncrypted = txtFilePath.Text.Remove(txtFilePath.Text.Length - 9);
					File.WriteAllBytes(fileEncrypted, bytesDecrypted);
					MessageBox.Show("File decrypted according to the password!");
				}
				catch
				{
					MessageBox.Show("Error!");
				}
			}
			/*else
				MessageBox.Show("No file choosen!");*/
		}

        private void button1_Click(object sender, EventArgs e)
        {
			Decryption.ActiveForm.Visible = false;
			PECDeviceUtility frm = new PECDeviceUtility();
			frm.Show();
		}
    }
}
