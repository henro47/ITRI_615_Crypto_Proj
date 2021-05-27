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
                            setUpSaveFileDialogE(saveFileDialog1);
                        }
                        else
                        {
                            outputResult = vigenere.decryptVigenere(inputFile, txtVigKey.Text);
                            setUpSaveFileDialogD(saveFileDialog1);
                        }
                  
                        saveFileDialog1.InitialDirectory = @"C:\";
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            try
                            { 
                                File.WriteAllBytes(saveFileDialog1.FileName, outputResult);
                                File.Delete(openFileDialog1.FileName);
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
                openFileDialog1.Title = "Upload any File";
                if(openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    inputFile = File.ReadAllBytes(openFileDialog1.FileName);
                    File.Delete(openFileDialog1.FileName);
                    if (rbVerEncrypt.Checked)
                    {
                        KeyGenerator generator = new KeyGenerator();
                        key = generator.generateKey(inputFile.Length);
                        VernamCipher vernam = new VernamCipher();
                        outputFile = vernam.executeVernam(inputFile, key);
                        vernamFileSaveEncrypt(outputFile, key);
                        File.Delete(openFileDialog1.FileName);
                    }
                    else
                    {
                        openFileDialog1.InitialDirectory = @"C:\";
                        openFileDialog1.Title = "Upload Encryption/Decryption Key";
                        if(openFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            key = File.ReadAllBytes(openFileDialog1.FileName);
                            File.Delete(openFileDialog1.FileName);
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
            setUpSaveFileDialogE(saveFileDialog1);
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.Title = "Save Encrypted File and Key";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {                 
                    File.WriteAllBytes(saveFileDialog1.FileName, file);
                    File.WriteAllBytes(saveFileDialog1.FileName+ "_key", key);
                    MessageBox.Show("Operation Successful", "File created and key written to file.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            setUpSaveFileDialogD(saveFileDialog1);
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.Title = "Save Decrypted File";
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

        private void rbOAEncrypt_CheckedChanged(object sender, EventArgs e)
        {
            if(rbOADecrypt.Checked)
            {
                rbOAEncrypt.Checked = false;
            }
        }

        private void rbOADecrypt_CheckedChanged(object sender, EventArgs e)
        {
            if(rbOAEncrypt.Checked)
            {
                rbOADecrypt.Checked = false;
            }
        }

        private void btnOAGenKey_Click(object sender, EventArgs e)
        {
            KeyGenerator generator = new KeyGenerator();
            txtOAKey.Text = Convert.ToBase64String(generator.generateKey(10));
        }

        private void btnUpload_Click_1(object sender, EventArgs e)
        {
            if (txtOAKey.Text != "")
            {
                byte[] outputFile;
                byte[] key;

                if(rbOAEncrypt.Checked)
                {
                    openFileDialog1.InitialDirectory = @"C:\";
                    openFileDialog1.Title = "Upload any File";
                    if(openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        key = Encoding.UTF8.GetBytes(txtOAKey.Text);
                        AESHorcrux aes = new AESHorcrux();
                        outputFile = File.ReadAllBytes(openFileDialog1.FileName);
                        byte[][] outFiles = aes.splitFiles(outputFile);
                        byte[][] encrypted = aes.encryptFile(outFiles, key);
                        if(AESHorcruxSaveEfiles(encrypted) && encrypted != null)
                        {
                            MessageBox.Show("Operation Successful", "File created", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            File.Delete(openFileDialog1.FileName);
                        }
                    }
                }
                else
                {
                    openFileDialog1.Multiselect = true;
                    openFileDialog1.InitialDirectory = @"C:\";
                    openFileDialog1.Title = "Select the 7 Horcrux files";
                   
                    if(openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string[] filesNames = openFileDialog1.FileNames.ToArray();
                        byte[][] inFiles = new byte[filesNames.Length][];
                        for(int i =0; i<filesNames.Length;i++)
                        {
                            inFiles[i] = File.ReadAllBytes(filesNames[i]);
                        }

                        key = Encoding.UTF8.GetBytes(txtOAKey.Text);
                        AESHorcrux aes = new AESHorcrux();
                        byte[][] decrypted = aes.decryptFile(inFiles, key);
                        outputFile = aes.combineFiles(decrypted);                  
                        if (AESHorcruxSaveDfiles(outputFile) && outputFile != null) ;
                        {
                            MessageBox.Show("Operation Successful", "File created", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            foreach(string file in filesNames)
                            {
                                File.Delete(file);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter or generate key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AESHorcruxSaveEfiles(byte[][] files)
        {
            try
            {
                setUpSaveFileDialogE(saveFileDialog1);
                saveFileDialog1.InitialDirectory = @"C:\";
                saveFileDialog1.Title = "Save file(s)";
                
                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    for(int i=0;i<7;i++)
                    {
                        File.WriteAllBytes(saveFileDialog1.FileName + "_Part" + (i + 1),files[i]);
                    }
                    return true;
                }
                return false;
            }
            catch(IOException err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool AESHorcruxSaveDfiles(byte[] file)
        {
            try
            {
                setUpSaveFileDialogD(saveFileDialog1);
                saveFileDialog1.InitialDirectory = @"C:\";
                saveFileDialog1.Title = "Save any File";
                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(saveFileDialog1.FileName, file);
                   
                }
                return true;
            }
            catch(IOException err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void setUpSaveFileDialogE(SaveFileDialog dialog)
        {
            dialog.Filter = "Data Files (*.dat)|*.dat";
            dialog.DefaultExt = "dat";
            dialog.AddExtension = true;
        }

        private void setUpSaveFileDialogD(SaveFileDialog dialog)
        {
            dialog.Filter = "Word Documents|*.doc|Excel Worksheets|*.xls|PowerPoint Presentations|*.ppt"
            + "|Office Files|*.doc;*.xls;*.ppt"
            + "|All Files|*.*"
            + "|Image files| *.jpg; *.jpeg; *.jpe; *.jfif; *.png"
            + "|PDF| *.pdf";
            dialog.DefaultExt = "";
            dialog.AddExtension = true;
        }

        private void btnTransGen_Click(object sender, EventArgs e)
        {
            KeyGenerator generator = new KeyGenerator();
            txtTransKey.Text = Convert.ToBase64String(generator.generateKey());
        }

        private void btnTransUpload_Click(object sender, EventArgs e)
        {
            if(txtTransKey.Text != "")
            {
                byte[] inputFile;
                string key = txtTransKey.Text;

                openFileDialog1.InitialDirectory = @"C:\";
                
                if(openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    inputFile = File.ReadAllBytes(openFileDialog1.FileName);
                    if(rbTransEncrypt.Checked)
                    {
                        ColumnarTranspositionCipher trans = new ColumnarTranspositionCipher();
                        byte[] output = trans.doColumnar(inputFile, key);
                        saveFileDialog1.InitialDirectory = @"C:\";
                        setUpSaveFileDialogE(saveFileDialog1);
                        if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            try
                            {
                                if (output != null)
                                {
                                    File.WriteAllBytes(saveFileDialog1.FileName, output);
                                    File.Delete(openFileDialog1.FileName);
                                    MessageBox.Show("Operation Successful", "File created", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                            catch(IOException err)
                            {
                                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        ColumnarTranspositionCipher trans = new ColumnarTranspositionCipher();
                        byte[] output = trans.doColumnar(inputFile, key);
                        saveFileDialog1.InitialDirectory = @"C:\";
                        setUpSaveFileDialogD(saveFileDialog1);
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            try
                            {
                                if(output != null)
                                {
                                    File.WriteAllBytes(saveFileDialog1.FileName, output);
                                    File.Delete(openFileDialog1.FileName);
                                    MessageBox.Show("Operation Successful", "File created", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                            catch(IOException err)
                            {
                                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter or generate key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbTransEncrypt_CheckedChanged(object sender, EventArgs e)
        {
            if(rbTransDecrypt.Checked)
            {
                rbTransEncrypt.Checked = false;
            }
        }

        private void rbTransDecrypt_CheckedChanged(object sender, EventArgs e)
        {
            if(rbTransEncrypt.Checked)
            {
                rbTransDecrypt.Checked = false;
            }
        }
    }
}
