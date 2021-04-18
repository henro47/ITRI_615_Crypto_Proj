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
            this.rbDecrypt = new System.Windows.Forms.RadioButton();
            this.rbEncrypt = new System.Windows.Forms.RadioButton();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnGenerateKey = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.tpVernam = new System.Windows.Forms.TabPage();
            this.tpTransposition = new System.Windows.Forms.TabPage();
            this.tpOwnAlgo = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tcAlgorithms.SuspendLayout();
            this.tpVigenere.SuspendLayout();
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
            // 
            // tpVigenere
            // 
            this.tpVigenere.Controls.Add(this.rbDecrypt);
            this.tpVigenere.Controls.Add(this.rbEncrypt);
            this.tpVigenere.Controls.Add(this.btnUpload);
            this.tpVigenere.Controls.Add(this.btnGenerateKey);
            this.tpVigenere.Controls.Add(this.txtKey);
            this.tpVigenere.Controls.Add(this.lblKey);
            this.tpVigenere.Location = new System.Drawing.Point(4, 25);
            this.tpVigenere.Name = "tpVigenere";
            this.tpVigenere.Padding = new System.Windows.Forms.Padding(3);
            this.tpVigenere.Size = new System.Drawing.Size(885, 439);
            this.tpVigenere.TabIndex = 0;
            this.tpVigenere.Text = "Vigenere";
            this.tpVigenere.UseVisualStyleBackColor = true;
            // 
            // rbDecrypt
            // 
            this.rbDecrypt.AutoSize = true;
            this.rbDecrypt.Location = new System.Drawing.Point(742, 59);
            this.rbDecrypt.Name = "rbDecrypt";
            this.rbDecrypt.Size = new System.Drawing.Size(104, 21);
            this.rbDecrypt.TabIndex = 5;
            this.rbDecrypt.TabStop = true;
            this.rbDecrypt.Text = "Decrypt File";
            this.rbDecrypt.UseVisualStyleBackColor = true;
            this.rbDecrypt.CheckedChanged += new System.EventHandler(this.rbDecrypt_CheckedChanged);
            // 
            // rbEncrypt
            // 
            this.rbEncrypt.AutoSize = true;
            this.rbEncrypt.Checked = true;
            this.rbEncrypt.Location = new System.Drawing.Point(742, 25);
            this.rbEncrypt.Name = "rbEncrypt";
            this.rbEncrypt.Size = new System.Drawing.Size(103, 21);
            this.rbEncrypt.TabIndex = 4;
            this.rbEncrypt.TabStop = true;
            this.rbEncrypt.Text = "Encrypt File";
            this.rbEncrypt.UseVisualStyleBackColor = true;
            this.rbEncrypt.CheckedChanged += new System.EventHandler(this.rbEncrypt_CheckedChanged);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(30, 135);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(165, 46);
            this.btnUpload.TabIndex = 3;
            this.btnUpload.Text = "Upload File";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnGenerateKey
            // 
            this.btnGenerateKey.Location = new System.Drawing.Point(30, 59);
            this.btnGenerateKey.Name = "btnGenerateKey";
            this.btnGenerateKey.Size = new System.Drawing.Size(295, 44);
            this.btnGenerateKey.TabIndex = 2;
            this.btnGenerateKey.Text = "Generate Key";
            this.btnGenerateKey.UseVisualStyleBackColor = true;
            this.btnGenerateKey.Click += new System.EventHandler(this.btnGenerateKey_Click);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(140, 26);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(178, 22);
            this.txtKey.TabIndex = 1;
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
            this.tpVernam.Location = new System.Drawing.Point(4, 25);
            this.tpVernam.Name = "tpVernam";
            this.tpVernam.Padding = new System.Windows.Forms.Padding(3);
            this.tpVernam.Size = new System.Drawing.Size(885, 439);
            this.tpVernam.TabIndex = 1;
            this.tpVernam.Text = "Vernam";
            this.tpVernam.UseVisualStyleBackColor = true;
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
            this.tpOwnAlgo.Location = new System.Drawing.Point(4, 25);
            this.tpOwnAlgo.Name = "tpOwnAlgo";
            this.tpOwnAlgo.Size = new System.Drawing.Size(885, 439);
            this.tpOwnAlgo.TabIndex = 3;
            this.tpOwnAlgo.Text = "Own Algo";
            this.tpOwnAlgo.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAlgorithms;
        private System.Windows.Forms.TabPage tpVigenere;
        private System.Windows.Forms.Button btnGenerateKey;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.TabPage tpVernam;
        private System.Windows.Forms.TabPage tpTransposition;
        private System.Windows.Forms.TabPage tpOwnAlgo;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.RadioButton rbDecrypt;
        private System.Windows.Forms.RadioButton rbEncrypt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

