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
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnGenerateKey_Click(object sender, EventArgs e)
        {
            KeyGenerator keyGen = new KeyGenerator();
            txtVigKey.Text = Convert.ToBase64String(keyGen.generateKey());
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (txtVigKey.Text != "")
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
                        if (rbEncryptVig.Checked)
                        {
                            outputResult = vigenere.encryptVigenere(inputFile, txtVigKey.Text);
                        }
                        else
                        {
                            outputResult = vigenere.decryptVigenere(inputFile, txtVigKey.Text);
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
            if(rbEncryptVig.Checked)
            {
                rbDecryptVig.Checked = false;
            }
        
        }

        private void rbDecrypt_CheckedChanged(object sender, EventArgs e)
        {
            if(rbDecryptVig.Checked)
            {
                rbEncryptVig.Checked = false;
            }
           
        }

        private void tcAlgorithms_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtVigKey.Text = "";
        }

        private void rbVerEncrypt_CheckedChanged(object sender, EventArgs e)
        {
            if(rbVerEncrypt.Checked)
            {
                rbVerDecrypt.Checked = false;
            }
        }

        private void rbVerDecrypt_CheckedChanged(object sender, EventArgs e)
        {
            if(rbVerDecrypt.Checked)
            {
                rbVerEncrypt.Checked = false;
            }
        }

        private void btnVerUpload_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] inputFile;
                byte[] outputFile;
                byte[] key;

                openFileDialog1.InitialDirectory = @"C:\";
                if(openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    inputFile = File.ReadAllBytes(openFileDialog1.FileName);
                    if(rbVerEncrypt.Checked)
                    {
                        KeyGenerator generator = new KeyGenerator();
                        key = generator.generateKey(inputFile.Length);
                        VernamCipher vernam = new VernamCipher();
                        outputFile = vernam.executeVernam(inputFile, key);
                        vernamFileSaveEncrypt(outputFile, key);
                    }
                    else
                    {
                        openFileDialog1.InitialDirectory = @"C:\";
                        if(openFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            key = File.ReadAllBytes(openFileDialog1.FileName);
                            VernamCipher vernam = new VernamCipher();
                            outputFile = vernam.executeVernam(inputFile, key);
                            vernamFileSaveDecrypt(outputFile);
                        }
                    }        
                }
            }
            catch(IOException err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    
        }

        private bool vernamFileSaveEncrypt(byte[] file, byte[] key)
        {
            bool isSuccessful = false;
            saveFileDialog1.InitialDirectory = @"C:\";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllBytes(saveFileDialog1.FileName, file);
                    File.WriteAllBytes("key.dat", key);
                    MessageBox.Show("Operation Successful", "File created", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    isSuccessful = true;
                }
                catch (IOException err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    
                }        
            }
            return isSuccessful;
        }

        private bool vernamFileSaveDecrypt(byte[] file)
        {
            bool isSuccessful = false;
            saveFileDialog1.InitialDirectory = @"C:\";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllBytes(saveFileDialog1.FileName, file);
                    MessageBox.Show("Operation Successful", "File created", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    isSuccessful = true;
                }
                catch (IOException err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            return isSuccessful;
        }

    }
}
