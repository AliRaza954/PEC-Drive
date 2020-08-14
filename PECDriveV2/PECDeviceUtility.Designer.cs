namespace PECDriveV2
{
    partial class PECDeviceUtility
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PECDeviceUtility));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.compressForm = new System.Windows.Forms.Button();
            this.encryptForm = new System.Windows.Forms.Button();
            this.decompressForm = new System.Windows.Forms.Button();
            this.decryptForm = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "PEC Device Menu\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(670, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Portable, Encrypted and Compressed Mass Storage Software\r\n";
            // 
            // compressForm
            // 
            this.compressForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.compressForm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compressForm.Location = new System.Drawing.Point(261, 142);
            this.compressForm.Name = "compressForm";
            this.compressForm.Size = new System.Drawing.Size(245, 44);
            this.compressForm.TabIndex = 2;
            this.compressForm.Text = "Compress Data";
            this.compressForm.UseVisualStyleBackColor = true;
            this.compressForm.Click += new System.EventHandler(this.compressForm_Click);
            // 
            // encryptForm
            // 
            this.encryptForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.encryptForm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptForm.Location = new System.Drawing.Point(261, 214);
            this.encryptForm.Name = "encryptForm";
            this.encryptForm.Size = new System.Drawing.Size(245, 44);
            this.encryptForm.TabIndex = 3;
            this.encryptForm.Text = "Encrypt Data";
            this.encryptForm.UseVisualStyleBackColor = true;
            this.encryptForm.Click += new System.EventHandler(this.encryptForm_Click);
            // 
            // decompressForm
            // 
            this.decompressForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.decompressForm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decompressForm.Location = new System.Drawing.Point(261, 349);
            this.decompressForm.Name = "decompressForm";
            this.decompressForm.Size = new System.Drawing.Size(245, 44);
            this.decompressForm.TabIndex = 4;
            this.decompressForm.Text = "Decompress Data";
            this.decompressForm.UseVisualStyleBackColor = true;
            this.decompressForm.Click += new System.EventHandler(this.decompressForm_Click);
            // 
            // decryptForm
            // 
            this.decryptForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.decryptForm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptForm.Location = new System.Drawing.Point(261, 282);
            this.decryptForm.Name = "decryptForm";
            this.decryptForm.Size = new System.Drawing.Size(245, 44);
            this.decryptForm.TabIndex = 5;
            this.decryptForm.Text = "Decrypt Data";
            this.decryptForm.UseVisualStyleBackColor = true;
            this.decryptForm.Click += new System.EventHandler(this.decryptForm_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(643, 362);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 31);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // PECDeviceUtility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.decryptForm);
            this.Controls.Add(this.decompressForm);
            this.Controls.Add(this.encryptForm);
            this.Controls.Add(this.compressForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PECDeviceUtility";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PEC Mass Storage Software";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button compressForm;
        private System.Windows.Forms.Button encryptForm;
        private System.Windows.Forms.Button decompressForm;
        private System.Windows.Forms.Button decryptForm;
        private System.Windows.Forms.Button btnExit;
    }
}

