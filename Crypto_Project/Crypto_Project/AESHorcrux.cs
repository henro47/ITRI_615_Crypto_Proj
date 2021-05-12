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

            //try
           //{
                byte[] input = File.ReadAllBytes(inputFile);

                using (var AesService = new AesCryptoServiceProvider())
                {
                    AesService.IV = key;
                    AesService.Key = key;
                    AesService.Mode = CipherMode.CBC;
                    AesService.Padding = PaddingMode.None;

                    using (var memStream = new MemoryStream())
                    {
                        CryptoStream cryptoStream = new CryptoStream(memStream, AesService.CreateEncryptor(), CryptoStreamMode.Write);
                        cryptoStream.Write(input, 0, input.Length);
                        //cryptoStream.FlushFinalBlock();

                        return memStream.ToArray();
                    }
                }
           // }
            //catch
            //{
              //  return null;
           // }

        }

        public byte[] decryptFile(string inputFile, byte[] key)
        {
            //try
            //{
                byte[] input = File.ReadAllBytes(inputFile);

                using (var AesService = new AesCryptoServiceProvider())
                {
                    AesService.IV = key;
                    AesService.Key = key;
                    AesService.Mode = CipherMode.CBC;
                    AesService.Padding = PaddingMode.None;

                using (var memStream = new MemoryStream())
                    {
                        CryptoStream cryptoStream = new CryptoStream(memStream, AesService.CreateDecryptor(), CryptoStreamMode.Write);
                        cryptoStream.Write(input, 0, input.Length);

                        return memStream.ToArray();
                    }
                }
            //}
            //catch
           // {
               // return null;
            //}
        }

        public byte[][] splitEncrytedFile(byte[] file)
        {
            try
            {
                int splitSize = file.Length / 7;
                int finalSplit = 0;              
                byte[][] horcruxes = new byte[7][];
                /*horcruxes[0] = file.Take(splitSize).ToArray();
                int segements = splitSize;
                for (int i = 1; i < 6; i++)
                {
                    horcruxes[i] = file.Skip(segements).Take(splitSize).ToArray();
                    segements += splitSize;
                }
                horcruxes[6] = file.Skip(segements - splitSize).Take(file.Length - segements).ToArray();*/
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

        public byte[] combineEncryptedFiles(byte[][] files)
        {
            try
            {
                int size = 0;
                for(int i =0; i<files.Length;i++)
                {
                    size += files[i].Length;
                }

                byte[] combined = new byte[size];

                for(int i = 0; i <files.Length;i++)
                {
                    System.Buffer.BlockCopy(files[i], 0, combined, 0, files[i].Length);
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
