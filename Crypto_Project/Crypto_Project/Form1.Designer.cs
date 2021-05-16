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
            this.plaintxthidder = new System.Windows.Forms.Label();
            this.keylbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.encryptedtxtlbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.plaintxtlbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EncryptedText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PlainTexttxt = new System.Windows.Forms.TextBox();
            this.Keytxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpOwnAlgo = new System.Windows.Forms.TabPage();
            this.btnUpload = new System.Windows.Forms.Button();
            this.rbOADecrypt = new System.Windows.Forms.RadioButton();
            this.rbOAEncrypt = new System.Windows.Forms.RadioButton();
            this.btnOAGenKey = new System.Windows.Forms.Button();
            this.txtOAKey = new System.Windows.Forms.TextBox();
            this.lblOAkey = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.TranspositionEncrypt = new System.Windows.Forms.Button();
            this.TranspositionDecipher = new System.Windows.Forms.Button();
            this.tcAlgorithms.SuspendLayout();
            this.tpVigenere.SuspendLayout();
            this.tpVernam.SuspendLayout();
            this.tpTransposition.SuspendLayout();
            this.tpOwnAlgo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcAlgorithms
            // 
            this.tcAlgorithms.Controls.Add(this.tpVigenere);
            this.tcAlgorithms.Controls.Add(this.tpVernam);
            this.tcAlgorithms.Controls.Add(this.tpTransposition);
            this.tcAlgorithms.Controls.Add(this.tpOwnAlgo);
            this.tcAlgorithms.Location = new System.Drawing.Point(9, 10);
            this.tcAlgorithms.Margin = new System.Windows.Forms.Padding(2);
            this.tcAlgorithms.Name = "tcAlgorithms";
            this.tcAlgorithms.SelectedIndex = 0;
            this.tcAlgorithms.Size = new System.Drawing.Size(670, 380);
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
            this.tpVigenere.Location = new System.Drawing.Point(4, 22);
            this.tpVigenere.Margin = new System.Windows.Forms.Padding(2);
            this.tpVigenere.Name = "tpVigenere";
            this.tpVigenere.Padding = new System.Windows.Forms.Padding(2);
            this.tpVigenere.Size = new System.Drawing.Size(662, 354);
            this.tpVigenere.TabIndex = 0;
            this.tpVigenere.Text = "Vigenere";
            this.tpVigenere.UseVisualStyleBackColor = true;
            // 
            // rbDecryptVig
            // 
            this.rbDecryptVig.AutoSize = true;
            this.rbDecryptVig.Location = new System.Drawing.Point(556, 48);
            this.rbDecryptVig.Margin = new System.Windows.Forms.Padding(2);
            this.rbDecryptVig.Name = "rbDecryptVig";
            this.rbDecryptVig.Size = new System.Drawing.Size(81, 17);
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
            this.rbEncryptVig.Location = new System.Drawing.Point(556, 20);
            this.rbEncryptVig.Margin = new System.Windows.Forms.Padding(2);
            this.rbEncryptVig.Name = "rbEncryptVig";
            this.rbEncryptVig.Size = new System.Drawing.Size(80, 17);
            this.rbEncryptVig.TabIndex = 4;
            this.rbEncryptVig.TabStop = true;
            this.rbEncryptVig.Text = "Encrypt File";
            this.rbEncryptVig.UseVisualStyleBackColor = true;
            this.rbEncryptVig.CheckedChanged += new System.EventHandler(this.rbEncrypt_CheckedChanged);
            // 
            // btnUploadVig
            // 
            this.btnUploadVig.Location = new System.Drawing.Point(22, 110);
            this.btnUploadVig.Margin = new System.Windows.Forms.Padding(2);
            this.btnUploadVig.Name = "btnUploadVig";
            this.btnUploadVig.Size = new System.Drawing.Size(124, 37);
            this.btnUploadVig.TabIndex = 3;
            this.btnUploadVig.Text = "Upload File";
            this.btnUploadVig.UseVisualStyleBackColor = true;
            this.btnUploadVig.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnGenerateVigKey
            // 
            this.btnGenerateVigKey.Location = new System.Drawing.Point(22, 48);
            this.btnGenerateVigKey.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerateVigKey.Name = "btnGenerateVigKey";
            this.btnGenerateVigKey.Size = new System.Drawing.Size(221, 36);
            this.btnGenerateVigKey.TabIndex = 2;
            this.btnGenerateVigKey.Text = "Generate Key";
            this.btnGenerateVigKey.UseVisualStyleBackColor = true;
            this.btnGenerateVigKey.Click += new System.EventHandler(this.btnGenerateKey_Click);
            // 
            // txtVigKey
            // 
            this.txtVigKey.Location = new System.Drawing.Point(105, 21);
            this.txtVigKey.Margin = new System.Windows.Forms.Padding(2);
            this.txtVigKey.Name = "txtVigKey";
            this.txtVigKey.Size = new System.Drawing.Size(134, 20);
            this.txtVigKey.TabIndex = 1;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(20, 24);
            this.lblKey.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(81, 13);
            this.lblKey.TabIndex = 0;
            this.lblKey.Text = "Encryption Key:";
            // 
            // tpVernam
            // 
            this.tpVernam.Controls.Add(this.btnVerUpload);
            this.tpVernam.Controls.Add(this.rbVerDecrypt);
            this.tpVernam.Controls.Add(this.rbVerEncrypt);
            this.tpVernam.Location = new System.Drawing.Point(4, 22);
            this.tpVernam.Margin = new System.Windows.Forms.Padding(2);
            this.tpVernam.Name = "tpVernam";
            this.tpVernam.Padding = new System.Windows.Forms.Padding(2);
            this.tpVernam.Size = new System.Drawing.Size(662, 354);
            this.tpVernam.TabIndex = 1;
            this.tpVernam.Text = "Vernam";
            this.tpVernam.UseVisualStyleBackColor = true;
            // 
            // btnVerUpload
            // 
            this.btnVerUpload.Location = new System.Drawing.Point(21, 113);
            this.btnVerUpload.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerUpload.Name = "btnVerUpload";
            this.btnVerUpload.Size = new System.Drawing.Size(124, 37);
            this.btnVerUpload.TabIndex = 7;
            this.btnVerUpload.Text = "Upload File";
            this.btnVerUpload.UseVisualStyleBackColor = true;
            this.btnVerUpload.Click += new System.EventHandler(this.btnVerUpload_Click);
            // 
            // rbVerDecrypt
            // 
            this.rbVerDecrypt.AutoSize = true;
            this.rbVerDecrypt.Location = new System.Drawing.Point(567, 46);
            this.rbVerDecrypt.Margin = new System.Windows.Forms.Padding(2);
            this.rbVerDecrypt.Name = "rbVerDecrypt";
            this.rbVerDecrypt.Size = new System.Drawing.Size(81, 17);
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
            this.rbVerEncrypt.Location = new System.Drawing.Point(568, 24);
            this.rbVerEncrypt.Margin = new System.Windows.Forms.Padding(2);
            this.rbVerEncrypt.Name = "rbVerEncrypt";
            this.rbVerEncrypt.Size = new System.Drawing.Size(80, 17);
            this.rbVerEncrypt.TabIndex = 5;
            this.rbVerEncrypt.TabStop = true;
            this.rbVerEncrypt.Text = "Encrypt File";
            this.rbVerEncrypt.UseVisualStyleBackColor = true;
            this.rbVerEncrypt.CheckedChanged += new System.EventHandler(this.rbVerEncrypt_CheckedChanged);
            // 
            // tpTransposition
            // 
            this.tpTransposition.Controls.Add(this.TranspositionDecipher);
            this.tpTransposition.Controls.Add(this.TranspositionEncrypt);
            this.tpTransposition.Controls.Add(this.plaintxthidder);
            this.tpTransposition.Controls.Add(this.keylbl);
            this.tpTransposition.Controls.Add(this.label8);
            this.tpTransposition.Controls.Add(this.encryptedtxtlbl);
            this.tpTransposition.Controls.Add(this.label6);
            this.tpTransposition.Controls.Add(this.plaintxtlbl);
            this.tpTransposition.Controls.Add(this.label4);
            this.tpTransposition.Controls.Add(this.EncryptedText);
            this.tpTransposition.Controls.Add(this.label3);
            this.tpTransposition.Controls.Add(this.label2);
            this.tpTransposition.Controls.Add(this.PlainTexttxt);
            this.tpTransposition.Controls.Add(this.Keytxt);
            this.tpTransposition.Controls.Add(this.label1);
            this.tpTransposition.Location = new System.Drawing.Point(4, 22);
            this.tpTransposition.Margin = new System.Windows.Forms.Padding(2);
            this.tpTransposition.Name = "tpTransposition";
            this.tpTransposition.Size = new System.Drawing.Size(662, 354);
            this.tpTransposition.TabIndex = 2;
            this.tpTransposition.Text = "Transposition";
            this.tpTransposition.UseVisualStyleBackColor = true;
            // 
            // plaintxthidder
            // 
            this.plaintxthidder.AutoSize = true;
            this.plaintxthidder.Location = new System.Drawing.Point(593, 338);
            this.plaintxthidder.Name = "plaintxthidder";
            this.plaintxthidder.Size = new System.Drawing.Size(0, 13);
            this.plaintxthidder.TabIndex = 18;
            this.plaintxthidder.Visible = false;
            // 
            // keylbl
            // 
            this.keylbl.AutoSize = true;
            this.keylbl.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keylbl.Location = new System.Drawing.Point(366, 96);
            this.keylbl.Name = "keylbl";
            this.keylbl.Size = new System.Drawing.Size(0, 20);
            this.keylbl.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(278, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Key:";
            // 
            // encryptedtxtlbl
            // 
            this.encryptedtxtlbl.AutoSize = true;
            this.encryptedtxtlbl.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptedtxtlbl.Location = new System.Drawing.Point(366, 65);
            this.encryptedtxtlbl.Name = "encryptedtxtlbl";
            this.encryptedtxtlbl.Size = new System.Drawing.Size(0, 20);
            this.encryptedtxtlbl.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Encrypted Text:";
            // 
            // plaintxtlbl
            // 
            this.plaintxtlbl.AutoSize = true;
            this.plaintxtlbl.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plaintxtlbl.Location = new System.Drawing.Point(366, 30);
            this.plaintxtlbl.Name = "plaintxtlbl";
            this.plaintxtlbl.Size = new System.Drawing.Size(0, 20);
            this.plaintxtlbl.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Plain Text:";
            // 
            // EncryptedText
            // 
            this.EncryptedText.Location = new System.Drawing.Point(124, 95);
            this.EncryptedText.Multiline = true;
            this.EncryptedText.Name = "EncryptedText";
            this.EncryptedText.Size = new System.Drawing.Size(110, 20);
            this.EncryptedText.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Encrypted Text:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Text To Encrypt:";
            // 
            // PlainTexttxt
            // 
            this.PlainTexttxt.Location = new System.Drawing.Point(124, 62);
            this.PlainTexttxt.Name = "PlainTexttxt";
            this.PlainTexttxt.Size = new System.Drawing.Size(110, 20);
            this.PlainTexttxt.TabIndex = 8;
            // 
            // Keytxt
            // 
            this.Keytxt.Location = new System.Drawing.Point(124, 27);
            this.Keytxt.Name = "Keytxt";
            this.Keytxt.Size = new System.Drawing.Size(110, 20);
            this.Keytxt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Encryption Key:";
            // 
            // tpOwnAlgo
            // 
            this.tpOwnAlgo.Controls.Add(this.btnUpload);
            this.tpOwnAlgo.Controls.Add(this.rbOADecrypt);
            this.tpOwnAlgo.Controls.Add(this.rbOAEncrypt);
            this.tpOwnAlgo.Controls.Add(this.btnOAGenKey);
            this.tpOwnAlgo.Controls.Add(this.txtOAKey);
            this.tpOwnAlgo.Controls.Add(this.lblOAkey);
            this.tpOwnAlgo.Location = new System.Drawing.Point(4, 22);
            this.tpOwnAlgo.Margin = new System.Windows.Forms.Padding(2);
            this.tpOwnAlgo.Name = "tpOwnAlgo";
            this.tpOwnAlgo.Size = new System.Drawing.Size(662, 354);
            this.tpOwnAlgo.TabIndex = 3;
            this.tpOwnAlgo.Text = "AES_Horcrux";
            this.tpOwnAlgo.UseVisualStyleBackColor = true;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(13, 135);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(124, 37);
            this.btnUpload.TabIndex = 7;
            this.btnUpload.Text = "Upload File(s)";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click_1);
            // 
            // rbOADecrypt
            // 
            this.rbOADecrypt.AutoSize = true;
            this.rbOADecrypt.Location = new System.Drawing.Point(577, 39);
            this.rbOADecrypt.Margin = new System.Windows.Forms.Padding(2);
            this.rbOADecrypt.Name = "rbOADecrypt";
            this.rbOADecrypt.Size = new System.Drawing.Size(81, 17);
            this.rbOADecrypt.TabIndex = 6;
            this.rbOADecrypt.TabStop = true;
            this.rbOADecrypt.Text = "Decrypt File";
            this.rbOADecrypt.UseVisualStyleBackColor = true;
            this.rbOADecrypt.CheckedChanged += new System.EventHandler(this.rbOADecrypt_CheckedChanged);
            // 
            // rbOAEncrypt
            // 
            this.rbOAEncrypt.AutoSize = true;
            this.rbOAEncrypt.Checked = true;
            this.rbOAEncrypt.Location = new System.Drawing.Point(577, 17);
            this.rbOAEncrypt.Margin = new System.Windows.Forms.Padding(2);
            this.rbOAEncrypt.Name = "rbOAEncrypt";
            this.rbOAEncrypt.Size = new System.Drawing.Size(80, 17);
            this.rbOAEncrypt.TabIndex = 5;
            this.rbOAEncrypt.TabStop = true;
            this.rbOAEncrypt.Text = "Encrypt File";
            this.rbOAEncrypt.UseVisualStyleBackColor = true;
            this.rbOAEncrypt.CheckedChanged += new System.EventHandler(this.rbOAEncrypt_CheckedChanged);
            // 
            // btnOAGenKey
            // 
            this.btnOAGenKey.Location = new System.Drawing.Point(13, 50);
            this.btnOAGenKey.Margin = new System.Windows.Forms.Padding(2);
            this.btnOAGenKey.Name = "btnOAGenKey";
            this.btnOAGenKey.Size = new System.Drawing.Size(221, 36);
            this.btnOAGenKey.TabIndex = 3;
            this.btnOAGenKey.Text = "Generate Key";
            this.btnOAGenKey.UseVisualStyleBackColor = true;
            this.btnOAGenKey.Click += new System.EventHandler(this.btnOAGenKey_Click);
            // 
            // txtOAKey
            // 
            this.txtOAKey.Location = new System.Drawing.Point(95, 15);
            this.txtOAKey.Margin = new System.Windows.Forms.Padding(2);
            this.txtOAKey.Name = "txtOAKey";
            this.txtOAKey.Size = new System.Drawing.Size(134, 20);
            this.txtOAKey.TabIndex = 2;
            // 
            // lblOAkey
            // 
            this.lblOAkey.AutoSize = true;
            this.lblOAkey.Location = new System.Drawing.Point(10, 17);
            this.lblOAkey.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOAkey.Name = "lblOAkey";
            this.lblOAkey.Size = new System.Drawing.Size(81, 13);
            this.lblOAkey.TabIndex = 1;
            this.lblOAkey.Text = "Encryption Key:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TranspositionEncrypt
            // 
            this.TranspositionEncrypt.Location = new System.Drawing.Point(44, 178);
            this.TranspositionEncrypt.Name = "TranspositionEncrypt";
            this.TranspositionEncrypt.Size = new System.Drawing.Size(75, 23);
            this.TranspositionEncrypt.TabIndex = 19;
            this.TranspositionEncrypt.Text = "Encrypt";
            this.TranspositionEncrypt.UseVisualStyleBackColor = true;
            this.TranspositionEncrypt.Click += new System.EventHandler(this.TranspositionEncrypt_Click);
            // 
            // TranspositionDecipher
            // 
            this.TranspositionDecipher.Location = new System.Drawing.Point(260, 178);
            this.TranspositionDecipher.Name = "TranspositionDecipher";
            this.TranspositionDecipher.Size = new System.Drawing.Size(75, 23);
            this.TranspositionDecipher.TabIndex = 20;
            this.TranspositionDecipher.Text = "Decipher";
            this.TranspositionDecipher.UseVisualStyleBackColor = true;
            this.TranspositionDecipher.Click += new System.EventHandler(this.TranspositionDecipher_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 400);
            this.Controls.Add(this.tcAlgorithms);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ITRI 615 Cryptography Project";
            this.tcAlgorithms.ResumeLayout(false);
            this.tpVigenere.ResumeLayout(false);
            this.tpVigenere.PerformLayout();
            this.tpVernam.ResumeLayout(false);
            this.tpVernam.PerformLayout();
            this.tpTransposition.ResumeLayout(false);
            this.tpTransposition.PerformLayout();
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
        private System.Windows.Forms.RadioButton rbVerDecrypt;
        private System.Windows.Forms.RadioButton rbVerEncrypt;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.RadioButton rbOADecrypt;
        private System.Windows.Forms.RadioButton rbOAEncrypt;
        private System.Windows.Forms.Button btnOAGenKey;
        private System.Windows.Forms.TextBox txtOAKey;
        private System.Windows.Forms.Label lblOAkey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerUpload;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PlainTexttxt;
        private System.Windows.Forms.TextBox Keytxt;
        private System.Windows.Forms.TextBox EncryptedText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label plaintxthidder;
        private System.Windows.Forms.Label keylbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label encryptedtxtlbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label plaintxtlbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button TranspositionDecipher;
        private System.Windows.Forms.Button TranspositionEncrypt;
    }
}

