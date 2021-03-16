using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Crypto_Project
{
    class KeyGenerator
    {
        private const string VALID = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
        private const int LENGTH = 15;
        public string generateKey()
        {
            StringBuilder res = new StringBuilder();
            using(RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                int length = LENGTH;
                byte[] uintBuffer = new byte[sizeof(uint)];
                while (length-- > 0)
                {
                    rng.GetBytes(uintBuffer);
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    res.Append(VALID[(int)(num % (uint)VALID.Length)]);
                }
            }
            return res.ToString();
        }

    }
}
