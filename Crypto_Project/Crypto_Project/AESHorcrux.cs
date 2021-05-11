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
        public byte[] encryptFile(string inputFile, byte[] key)
        {

            try
            {
                byte[] input = File.ReadAllBytes(inputFile);

                using (var AesService = new AesCryptoServiceProvider())
                {
                    AesService.IV = key;
                    AesService.Key = key;
                    AesService.Mode = CipherMode.CBC;
                    AesService.Padding = PaddingMode.PKCS7;

                    using (var memStream = new MemoryStream())
                    {
                        CryptoStream cryptoStream = new CryptoStream(memStream, AesService.CreateEncryptor(), CryptoStreamMode.Write);
                        cryptoStream.Write(input, 0, input.Length);
                        cryptoStream.FlushFinalBlock();

                        return memStream.ToArray();
                    }
                }
            }
            catch
            {
                return null;
            }

        }

        public byte[] decryptFile(string inputFile, byte[] key)
        {
            try
            {
                byte[] input = File.ReadAllBytes(inputFile);

                using (var AesService = new AesCryptoServiceProvider())
                {
                    AesService.IV = key;
                    AesService.Key = key;
                    AesService.Mode = CipherMode.CBC;
                    AesService.Padding = PaddingMode.PKCS7;

                    using (var memStream = new MemoryStream())
                    {
                        CryptoStream cryptoStream = new CryptoStream(memStream, AesService.CreateDecryptor(), CryptoStreamMode.Write);
                        cryptoStream.Write(input, 0, input.Length);
                        cryptoStream.FlushFinalBlock();

                        return memStream.ToArray();
                    }
                }
            }
            catch
            {
                return null;
            }
        }

        public byte[][] splitEncrytedFile(byte[] file)
        {
            try
            {
                int splitSize = file.Length / 7;
                byte[][] horcruxes = new byte[7][];
                horcruxes[0] = file.Take(splitSize).ToArray();
                int segements = splitSize;
                for (int i = 1; i < 6; i++)
                {
                    horcruxes[i] = file.Skip(segements).Take(splitSize).ToArray();
                    segements += splitSize;
                }
                horcruxes[6] = file.Skip(segements - splitSize).Take(file.Length - segements).ToArray();
                return horcruxes;
            }
            catch
            {
                return null;
            }
        }

        public byte[] combineEncryptedFiles(byte[][] files)
        {
            try
            {
                byte[] finalFile = files.SelectMany(i => i).ToArray();
                return finalFile;
            }
            catch
            {
                return null;
            }
        }
    }
}
