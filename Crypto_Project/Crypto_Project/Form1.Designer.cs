namespace Crypto_Project
{
    partial class frmMain
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
            this.tcAlgorithms = new System.Windows.Forms.TabControl();
            this.tpVigenere = new System.Windows.Forms.TabPage();
            this.rbDecryptVig = new System.Windows.Forms.RadioButton();
            this.rbEncryptVig = new System.Windows.Forms.RadioButton();
            this.btnUploadVig = new System.Windows.Forms.Button();
            this.btnGenerateVigKey = new System.Windows.Forms.Button();
            this.txtVigKey = new System.Windows.Forms.TextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.tpVernam = new System.Windows.Forms.TabPage();
            this.btnVerUpload = new System.Windows.Forms.Button();
            this.rbVerDecrypt = new System.Windows.Forms.RadioButton();
            this.rbVerEncrypt = new System.Windows.Forms.RadioButton();
            this.tpTransposition = new System.Windows.Forms.TabPage();
            this.tpOwnAlgo = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lblOAkey = new System.Windows.Forms.Label();
            this.txtOAKey = new System.Windows.Forms.TextBox();
            this.btnOAGenKey = new System.Windows.Forms.Button();
            this.rbOAEncrypt = new System.Windows.Forms.RadioButton();
            this.rbOADecrypt = new System.Windows.Forms.RadioButton();
            this.btnUpload = new System.Windows.Forms.Button();
            this.tcAlgorithms.SuspendLayout();
            this.tpVigenere.SuspendLayout();
            this.tpVernam.SuspendLayout();
            this.tpOwnAlgo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcAlgorithms
            // 
            this.tcAlgorithms.Controls.Add(this.tpVigenere);
            this.tcAlgorithms.Controls.Add(this.tpVernam);
            this.tcAlgorithms.Controls.Add(this.tpTransposition);
            this.tcAlgorithms.Controls.Add(this.tpOwnAlgo);
            this.tcAlgorithms.Location = new System.Drawing.Point(12, 12);
            this.tcAlgorithms.Name = "tcAlgorithms";
            this.tcAlgorithms.SelectedIndex = 0;
            this.tcAlgorithms.Size = new System.Drawing.Size(893, 468);
            this.tcAlgorithms.TabIndex = 0;
            this.tcAlgorithms.SelectedIndexChanged += new System.EventHandler(this.tcAlgorithms_SelectedIndexChanged);
            // 
            // tpVigenere
            // 
            this.tpVigenere.Controls.Add(this.rbDecryptVig);
            this.tpVigenere.Controls.Add(this.rbEncryptVig);
            this.tpVigenere.Controls.Add(this.btnUploadVig);
            this.tpVigenere.Controls.Add(this.btnGenerateVigKey);
            this.tpVigenere.Controls.Add(this.txtVigKey);
            this.tpVigenere.Controls.Add(this.lblKey);
            this.tpVigenere.Location = new System.Drawing.Point(4, 25);
            this.tpVigenere.Name = "tpVigenere";
            this.tpVigenere.Padding = new System.Windows.Forms.Padding(3);
            this.tpVigenere.Size = new System.Drawing.Size(885, 439);
            this.tpVigenere.TabIndex = 0;
            this.tpVigenere.Text = "Vigenere";
            this.tpVigenere.UseVisualStyleBackColor = true;
            // 
            // rbDecryptVig
            // 
            this.rbDecryptVig.AutoSize = true;
            this.rbDecryptVig.Location = new System.Drawing.Point(742, 59);
            this.rbDecryptVig.Name = "rbDecryptVig";
            this.rbDecryptVig.Size = new System.Drawing.Size(104, 21);
            this.rbDecryptVig.TabIndex = 5;
            this.rbDecryptVig.TabStop = true;
            this.rbDecryptVig.Text = "Decrypt File";
            this.rbDecryptVig.UseVisualStyleBackColor = true;
            this.rbDecryptVig.CheckedChanged += new System.EventHandler(this.rbDecrypt_CheckedChanged);
            // 
            // rbEncryptVig
            // 
            this.rbEncryptVig.AutoSize = true;
            this.rbEncryptVig.Checked = true;
            this.rbEncryptVig.Location = new System.Drawing.Point(742, 25);
            this.rbEncryptVig.Name = "rbEncryptVig";
            this.rbEncryptVig.Size = new System.Drawing.Size(103, 21);
            this.rbEncryptVig.TabIndex = 4;
            this.rbEncryptVig.TabStop = true;
            this.rbEncryptVig.Text = "Encrypt File";
            this.rbEncryptVig.UseVisualStyleBackColor = true;
            this.rbEncryptVig.CheckedChanged += new System.EventHandler(this.rbEncrypt_CheckedChanged);
            // 
            // btnUploadVig
            // 
            this.btnUploadVig.Location = new System.Drawing.Point(30, 135);
            this.btnUploadVig.Name = "btnUploadVig";
            this.btnUploadVig.Size = new System.Drawing.Size(165, 46);
            this.btnUploadVig.TabIndex = 3;
            this.btnUploadVig.Text = "Upload File";
            this.btnUploadVig.UseVisualStyleBackColor = true;
            this.btnUploadVig.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnGenerateVigKey
            // 
            this.btnGenerateVigKey.Location = new System.Drawing.Point(30, 59);
            this.btnGenerateVigKey.Name = "btnGenerateVigKey";
            this.btnGenerateVigKey.Size = new System.Drawing.Size(295, 44);
            this.btnGenerateVigKey.TabIndex = 2;
            this.btnGenerateVigKey.Text = "Generate Key";
            this.btnGenerateVigKey.UseVisualStyleBackColor = true;
            this.btnGenerateVigKey.Click += new System.EventHandler(this.btnGenerateKey_Click);
            // 
            // txtVigKey
            // 
            this.txtVigKey.Location = new System.Drawing.Point(140, 26);
            this.txtVigKey.Name = "txtVigKey";
            this.txtVigKey.Size = new System.Drawing.Size(178, 22);
            this.txtVigKey.TabIndex = 1;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(27, 29);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(107, 17);
            this.lblKey.TabIndex = 0;
            this.lblKey.Text = "Encryption Key:";
            // 
            // tpVernam
            // 
            this.tpVernam.Controls.Add(this.btnVerUpload);
            this.tpVernam.Controls.Add(this.rbVerDecrypt);
            this.tpVernam.Controls.Add(this.rbVerEncrypt);
            this.tpVernam.Location = new System.Drawing.Point(4, 25);
            this.tpVernam.Name = "tpVernam";
            this.tpVernam.Padding = new System.Windows.Forms.Padding(3);
            this.tpVernam.Size = new System.Drawing.Size(885, 439);
            this.tpVernam.TabIndex = 1;
            this.tpVernam.Text = "Vernam";
            this.tpVernam.UseVisualStyleBackColor = true;
            // 
            // btnVerUpload
            // 
            this.btnVerUpload.Location = new System.Drawing.Point(28, 139);
            this.btnVerUpload.Name = "btnVerUpload";
            this.btnVerUpload.Size = new System.Drawing.Size(165, 46);
            this.btnVerUpload.TabIndex = 7;
            this.btnVerUpload.Text = "Upload File";
            this.btnVerUpload.UseVisualStyleBackColor = true;
            this.btnVerUpload.Click += new System.EventHandler(this.btnVerUpload_Click);
            // 
            // rbVerDecrypt
            // 
            this.rbVerDecrypt.AutoSize = true;
            this.rbVerDecrypt.Location = new System.Drawing.Point(756, 56);
            this.rbVerDecrypt.Name = "rbVerDecrypt";
            this.rbVerDecrypt.Size = new System.Drawing.Size(104, 21);
            this.rbVerDecrypt.TabIndex = 6;
            this.rbVerDecrypt.TabStop = true;
            this.rbVerDecrypt.Text = "Decrypt File";
            this.rbVerDecrypt.UseVisualStyleBackColor = true;
            this.rbVerDecrypt.CheckedChanged += new System.EventHandler(this.rbVerDecrypt_CheckedChanged);
            // 
            // rbVerEncrypt
            // 
            this.rbVerEncrypt.AutoSize = true;
            this.rbVerEncrypt.Checked = true;
            this.rbVerEncrypt.Location = new System.Drawing.Point(757, 29);
            this.rbVerEncrypt.Name = "rbVerEncrypt";
            this.rbVerEncrypt.Size = new System.Drawing.Size(103, 21);
            this.rbVerEncrypt.TabIndex = 5;
            this.rbVerEncrypt.TabStop = true;
            this.rbVerEncrypt.Text = "Encrypt File";
            this.rbVerEncrypt.UseVisualStyleBackColor = true;
            this.rbVerEncrypt.CheckedChanged += new System.EventHandler(this.rbVerEncrypt_CheckedChanged);
            // 
            // tpTransposition
            // 
            this.tpTransposition.Location = new System.Drawing.Point(4, 25);
            this.tpTransposition.Name = "tpTransposition";
            this.tpTransposition.Size = new System.Drawing.Size(885, 439);
            this.tpTransposition.TabIndex = 2;
            this.tpTransposition.Text = "Transposition";
            this.tpTransposition.UseVisualStyleBackColor = true;
            // 
            // tpOwnAlgo
            // 
            this.tpOwnAlgo.Controls.Add(this.btnUpload);
            this.tpOwnAlgo.Controls.Add(this.rbOADecrypt);
            this.tpOwnAlgo.Controls.Add(this.rbOAEncrypt);
            this.tpOwnAlgo.Controls.Add(this.btnOAGenKey);
            this.tpOwnAlgo.Controls.Add(this.txtOAKey);
            this.tpOwnAlgo.Controls.Add(this.lblOAkey);
            this.tpOwnAlgo.Location = new System.Drawing.Point(4, 25);
            this.tpOwnAlgo.Name = "tpOwnAlgo";
            this.tpOwnAlgo.Size = new System.Drawing.Size(885, 439);
            this.tpOwnAlgo.TabIndex = 3;
            this.tpOwnAlgo.Text = "AES_Horcrux";
            this.tpOwnAlgo.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblOAkey
            // 
            this.lblOAkey.AutoSize = true;
            this.lblOAkey.Location = new System.Drawing.Point(14, 21);
            this.lblOAkey.Name = "lblOAkey";
            this.lblOAkey.Size = new System.Drawing.Size(107, 17);
            this.lblOAkey.TabIndex = 1;
            this.lblOAkey.Text = "Encryption Key:";
            // 
            // txtOAKey
            // 
            this.txtOAKey.Location = new System.Drawing.Point(127, 18);
            this.txtOAKey.Name = "txtOAKey";
            this.txtOAKey.Size = new System.Drawing.Size(178, 22);
            this.txtOAKey.TabIndex = 2;
            // 
            // btnOAGenKey
            // 
            this.btnOAGenKey.Location = new System.Drawing.Point(17, 61);
            this.btnOAGenKey.Name = "btnOAGenKey";
            this.btnOAGenKey.Size = new System.Drawing.Size(295, 44);
            this.btnOAGenKey.TabIndex = 3;
            this.btnOAGenKey.Text = "Generate Key";
            this.btnOAGenKey.UseVisualStyleBackColor = true;
            this.btnOAGenKey.Click += new System.EventHandler(this.btnOAGenKey_Click);
            // 
            // rbOAEncrypt
            // 
            this.rbOAEncrypt.AutoSize = true;
            this.rbOAEncrypt.Checked = true;
            this.rbOAEncrypt.Location = new System.Drawing.Point(769, 21);
            this.rbOAEncrypt.Name = "rbOAEncrypt";
            this.rbOAEncrypt.Size = new System.Drawing.Size(103, 21);
            this.rbOAEncrypt.TabIndex = 5;
            this.rbOAEncrypt.TabStop = true;
            this.rbOAEncrypt.Text = "Encrypt File";
            this.rbOAEncrypt.UseVisualStyleBackColor = true;
            this.rbOAEncrypt.CheckedChanged += new System.EventHandler(this.rbOAEncrypt_CheckedChanged);
            // 
            // rbOADecrypt
            // 
            this.rbOADecrypt.AutoSize = true;
            this.rbOADecrypt.Location = new System.Drawing.Point(769, 48);
            this.rbOADecrypt.Name = "rbOADecrypt";
            this.rbOADecrypt.Size = new System.Drawing.Size(104, 21);
            this.rbOADecrypt.TabIndex = 6;
            this.rbOADecrypt.TabStop = true;
            this.rbOADecrypt.Text = "Decrypt File";
            this.rbOADecrypt.UseVisualStyleBackColor = true;
            this.rbOADecrypt.CheckedChanged += new System.EventHandler(this.rbOADecrypt_CheckedChanged);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(17, 166);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(165, 46);
            this.btnUpload.TabIndex = 7;
            this.btnUpload.Text = "Upload File(s)";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click_1);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 492);
            this.Controls.Add(this.tcAlgorithms);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ITRI 615 Cryptography Project";
            this.tcAlgorithms.ResumeLayout(false);
            this.tpVigenere.ResumeLayout(false);
            this.tpVigenere.PerformLayout();
            this.tpVernam.ResumeLayout(false);
            this.tpVernam.PerformLayout();
            this.tpOwnAlgo.ResumeLayout(false);
            this.tpOwnAlgo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAlgorithms;
        private System.Windows.Forms.TabPage tpVigenere;
        private System.Windows.Forms.Button btnGenerateVigKey;
        private System.Windows.Forms.TextBox txtVigKey;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.TabPage tpVernam;
        private System.Windows.Forms.TabPage tpTransposition;
        private System.Windows.Forms.TabPage tpOwnAlgo;
        private System.Windows.Forms.Button btnUploadVig;
        private System.Windows.Forms.RadioButton rbDecryptVig;
        private System.Windows.Forms.RadioButton rbEncryptVig;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnVerUpload;
        private System.Windows.Forms.RadioButton rbVerDecrypt;
        private System.Windows.Forms.RadioButton rbVerEncrypt;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.RadioButton rbOADecrypt;
        private System.Windows.Forms.RadioButton rbOAEncrypt;
        private System.Windows.Forms.Button btnOAGenKey;
        private System.Windows.Forms.TextBox txtOAKey;
        private System.Windows.Forms.Label lblOAkey;
    }
}

