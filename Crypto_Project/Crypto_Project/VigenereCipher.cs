using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto_Project
{
    class VigenereCipher
    {
        private byte[] inputData;
        public VigenereCipher(byte [] inputData)
        {
            this.inputData = new byte[inputData.Length];
            setData(inputData);
        }

        private void setData(byte[] inputData)
        {
 
            for(int i = 0; i <inputData.Length; i++)
            {
                this.inputData[i] = inputData[i];
            } 
        }
        public byte getDataAtIndex(int index)
        {
            return this.inputData[index];
        }
    }
}
