using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto_Project
{
    class VigenereCipher
    {
        public byte[] encryptVigenere(byte[] plainText, string key)
        {
            byte[] cipherText = new byte[plainText.Length];

            key = key.Trim().ToUpper();

            int keyIndex = 0;
            int keyLength = key.Length;

            for(int i =0; i <plainText.Length; i++)
            {
                keyIndex = keyIndex % keyLength;
                int shift = (int)key[keyIndex] - 65;
                cipherText[i] = (byte)(((int)plainText[i] + shift) % 256);
                keyIndex++;
            }

            return cipherText;
        }

        public byte[] decryptVigenere(byte[] cipherText, string key)
        {
            byte[] plainText = new byte[cipherText.Length];

            key = key.Trim().ToUpper();

            int keyIndex = 0;
            int keyLength = key.Length;

            for(int i = 0; i <cipherText.Length;i++)
            {
                keyIndex = keyIndex % keyLength;
                int shift = (int)key[keyIndex] - 65;
                plainText[i] = (byte)(((int)cipherText[i] + 256 - shift) % 256);
                keyIndex++;
            }

            return plainText;
        }

    }
}
