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
                openFileDialog1.Title = "Upload any File";
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
                        openFileDialog1.Title = "Upload Encryption/Decryption Key";
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
            saveFileDialog1.Title = "Save Encrypted File and Key";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllBytes(saveFileDialog1.FileName, file);
                    File.WriteAllBytes(saveFileDialog1.FileName+ "_key.dat", key);
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

        private static int[] GetShiftIndexes(string key)
        {
            int keyLength = key.Length;
            int[] indexes = new int[keyLength];
            List<KeyValuePair<int, char>> sortedKey = new List<KeyValuePair<int, char>>();
            int i;

            for (i = 0; i < keyLength; ++i)
                sortedKey.Add(new KeyValuePair<int, char>(i, key[i]));

            sortedKey.Sort(
                delegate (KeyValuePair<int, char> pair1, KeyValuePair<int, char> pair2) {
                    return pair1.Value.CompareTo(pair2.Value);
                }
            );

            for (i = 0; i < keyLength; ++i)
                indexes[sortedKey[i].Key] = i;

            return indexes;
        }

        public static string Encipher(string input, string key, char padChar)
        {
            input = (input.Length % key.Length == 0) ? input : input.PadRight(input.Length - (input.Length % key.Length) + key.Length, padChar);
            StringBuilder output = new StringBuilder();
            int totalChars = input.Length;
            int totalColumns = key.Length;
            int totalRows = (int)Math.Ceiling((double)totalChars / totalColumns);
            char[,] rowChars = new char[totalRows, totalColumns];
            char[,] colChars = new char[totalColumns, totalRows];
            char[,] sortedColChars = new char[totalColumns, totalRows];
            int currentRow, currentColumn, i, j;
            int[] shiftIndexes = GetShiftIndexes(key);

            for (i = 0; i < totalChars; ++i)
            {
                currentRow = i / totalColumns;
                currentColumn = i % totalColumns;
                rowChars[currentRow, currentColumn] = input[i];
            }

            for (i = 0; i < totalRows; ++i)
                for (j = 0; j < totalColumns; ++j)
                    colChars[j, i] = rowChars[i, j];

            for (i = 0; i < totalColumns; ++i)
                for (j = 0; j < totalRows; ++j)
                    sortedColChars[shiftIndexes[i], j] = colChars[i, j];

            for (i = 0; i < totalChars; ++i)
            {
                currentRow = i / totalRows;
                currentColumn = i % totalRows;
                output.Append(sortedColChars[currentRow, currentColumn]);
            }

            return output.ToString();
        }

        public static string Decipher(string input, string key)
        {
            StringBuilder output = new StringBuilder();
            int totalChars = input.Length;
            int totalColumns = (int)Math.Ceiling((double)totalChars / key.Length);
            int totalRows = key.Length;
            char[,] rowChars = new char[totalRows, totalColumns];
            char[,] colChars = new char[totalColumns, totalRows];
            char[,] unsortedColChars = new char[totalColumns, totalRows];
            int currentRow, currentColumn, i, j;
            int[] shiftIndexes = GetShiftIndexes(key);

            for (i = 0; i < totalChars; ++i)
            {
                currentRow = i / totalColumns;
                currentColumn = i % totalColumns;
                rowChars[currentRow, currentColumn] = input[i];
            }

            for (i = 0; i < totalRows; ++i)
                for (j = 0; j < totalColumns; ++j)
                    colChars[j, i] = rowChars[i, j];

            for (i = 0; i < totalColumns; ++i)
                for (j = 0; j < totalRows; ++j)
                    unsortedColChars[i, j] = colChars[i, shiftIndexes[j]];

            for (i = 0; i < totalChars; ++i)
            {
                currentRow = i / totalRows;
                currentColumn = i % totalRows;
                output.Append(unsortedColChars[currentRow, currentColumn]);
            }

            return output.ToString();
        }

        private void TranspositionEncrypt_Click(object sender, EventArgs e)
        {
            if (Keytxt.Text == "")
            {
                MessageBox.Show("Please enter a key");
                keylbl.Text = "";
                encryptedtxtlbl.Text = "";
                plaintxtlbl.Text = "";
            }
            if (PlainTexttxt.Text == "")
            {
                MessageBox.Show("Please enter a plaintext");
                keylbl.Text = "";
                encryptedtxtlbl.Text = "";
            }
            string key = Keytxt.Text;
            string text = PlainTexttxt.Text;
            string encryptedtext = EncryptedText.Text;
            string cipherText = Encipher(text, key, '-');
            string plainText = Decipher(cipherText, key);

            keylbl.Text = Keytxt.Text;
            encryptedtxtlbl.Text = cipherText;
            plaintxthidder.Text = plainText;

            PlainTexttxt.Text = "";
            EncryptedText.Text = cipherText;
        }

        private void TranspositionDecipher_Click(object sender, EventArgs e)
        {
            string key = Keytxt.Text;
            string text = PlainTexttxt.Text;
            string encryptedtext = EncryptedText.Text;
            string cipherText = Encipher(text, key, '-');
            string plainText = Decipher(cipherText, key);

            if(Keytxt.Text == "")
            {
                MessageBox.Show("Please enter a key");
                keylbl.Text = "";
                encryptedtxtlbl.Text = "";
                plaintxtlbl.Text = "";
            }
            if(EncryptedText.Text == "")
            {
                MessageBox.Show("Please enter an encrypted text to decipher");
                keylbl.Text = "";
                encryptedtxtlbl.Text = "";
                plaintxtlbl.Text = "";
            }

            keylbl.Text = Keytxt.Text;
            plaintxtlbl.Text = plaintxthidder.Text;
        }
    }
    }

