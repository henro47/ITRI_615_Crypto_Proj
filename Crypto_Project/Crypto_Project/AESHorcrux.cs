using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Crypto_Project
{
    class AESHorcrux
    {
        public byte[][] encryptFile(byte[][] inputFiles, byte[] key)
        {

            //try
            //{
            byte[][] encryptedFiles = new byte[inputFiles.Length][];
            int count = 0;
            foreach (byte[] file in inputFiles)
            {

                using (var AesService = new AesCryptoServiceProvider())
                {
                    AesService.IV = key;
                    AesService.Key = key;
                    AesService.Mode = CipherMode.CBC;
                    AesService.Padding = PaddingMode.PKCS7;

                    using (var memStream = new MemoryStream())
                    {
                        CryptoStream cryptoStream = new CryptoStream(memStream, AesService.CreateEncryptor(), CryptoStreamMode.Write);
                        cryptoStream.Write(file, 0, file.Length);
                        cryptoStream.FlushFinalBlock();
                        encryptedFiles[count] = memStream.ToArray();
                        count++;
                    }
                }
            }

            return encryptedFiles;
            // }
            //catch
            //{
            //  return null;
            // }

        }

        public byte[][] decryptFile(byte[][] inputFiles, byte[] key)
        {
            //try
            //{
            byte[][] decryptedFiles = new byte[inputFiles.Length][];
            int count = 0;
            foreach (byte[] file in inputFiles)
            { 
                using (var AesService = new AesCryptoServiceProvider())
                {
                    AesService.IV = key;
                    AesService.Key = key;
                    AesService.Mode = CipherMode.CBC;
                    AesService.Padding = PaddingMode.PKCS7;

                    using (var memStream = new MemoryStream())
                    {
                        CryptoStream cryptoStream = new CryptoStream(memStream, AesService.CreateDecryptor(), CryptoStreamMode.Write);
                        cryptoStream.Write(file, 0, file.Length);
                        cryptoStream.FlushFinalBlock();

                        decryptedFiles[count] = memStream.ToArray();
                        count++;
                    }
                }
            }

            return decryptedFiles;
            //}
            //catch
            // {
            // return null;
            //}
        }

        public byte[][] splitFiles(byte[] file)
        {
            try
            {
                int splitSize = file.Length / 7;
                byte[][] horcruxes = new byte[7][];

                int count = 0;
                int countSize = 0;
                for (int i = 0; i < file.Length && count < 6; i += splitSize)
                {
                    byte[] buffer = new byte[splitSize];
                    Buffer.BlockCopy(file, i, buffer, 0, splitSize);
                    horcruxes[count] = buffer;
                    countSize += splitSize;
                    count++;
                }
                byte[] Finalbuffer = new byte[splitSize + file.Length % 7];
                Buffer.BlockCopy(file, countSize, Finalbuffer, 0, Finalbuffer.Length);
                horcruxes[6] = Finalbuffer;

                return horcruxes;
            }
            catch
            {
                return null;
            }
        }

        public byte[] combineFiles(byte[][] files)
        {
            try
            {
                int size = 0;
                int offset = 0;
                for (int i = 0; i < files.Length; i++)
                {
                    size += files[i].Length;
                }

                byte[] combined = new byte[size];

                foreach (byte[] file in files)
                {
                    System.Buffer.BlockCopy(file, 0, combined, offset, file.Length);
                    offset += file.Length;
                }

                return combined;
            }
            catch
            {
                return null;
            }
        }
    }
}
