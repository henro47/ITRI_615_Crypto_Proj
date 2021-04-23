using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto_Project
{
    class VernamCipher
    {
        public byte[] executeVernam(byte[] inputBytes, byte[] keyBytes)
        {
            if (inputBytes.Length != keyBytes.Length)
            {
                return null;
            }

            byte[] outputBytes = new byte[inputBytes.Length];

            for (int i = 0; i < inputBytes.Length; i++)
            {
                outputBytes[i] = (byte)(inputBytes[i] ^ keyBytes[i]);
            }

            return outputBytes;
        }
    }
}
