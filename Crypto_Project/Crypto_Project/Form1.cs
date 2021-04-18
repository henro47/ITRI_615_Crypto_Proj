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

namespace Crypto_Project
{
    public partial class frmMain : Form
    {
        private string file_path; 
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnGenerateKey_Click(object sender, EventArgs e)
        {
            KeyGenerator keyGen = new KeyGenerator();
            txtKey.Text = keyGen.generateKey();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (txtKey.Text != "")
            {
                //File (CipherText or PlainText)
                byte[] inputFile;
                byte[] outputResult;
                openFileDialog1.InitialDirectory = @"C:\";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        inputFile = File.ReadAllBytes(openFileDialog1.FileName);

                        //Encryption/Decryption
                        VigenereCipher vigenere = new VigenereCipher();
                        if (rbEncrypt.Checked)
                        {
                            outputResult = vigenere.encryptVigenere(inputFile, txtKey.Text);
                        }
                        else
                        {
                            outputResult = vigenere.decryptVigenere(inputFile, txtKey.Text);
                        }

                        saveFileDialog1.InitialDirectory = @"C:\";
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            try
                            { 
                                File.WriteAllBytes(saveFileDialog1.FileName, outputResult);
                                MessageBox.Show("Operation Successful", "File created", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                
                            }
                            catch (IOException err)
                            {
                                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (IOException err)
                    {
                        MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }  
            }
            else
            {
                MessageBox.Show("Please enter or generate key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbEncrypt_CheckedChanged(object sender, EventArgs e)
        {
            if(rbEncrypt.Checked)
            {
                rbDecrypt.Checked = false;
            }
        
        }

        private void rbDecrypt_CheckedChanged(object sender, EventArgs e)
        {
            if(rbDecrypt.Checked)
            {
                rbEncrypt.Checked = false;
            }
           
        }

    }
}
