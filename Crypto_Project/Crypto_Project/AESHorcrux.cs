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
    }
}
