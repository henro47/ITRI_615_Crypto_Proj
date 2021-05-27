using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto_Project
{
    class ColumnarTranspositionCipher
    {

        public byte[] doColumnar(byte[] inputFile, string key)
        {
            int colNo = key.Length;
            int rowNo = inputFile.Length / colNo;


            int countSize = 0;
            int count = 0;
            byte[][] columnTrans = new byte[rowNo][];

            for (int i = 0; i < inputFile.Length && count < rowNo - 1; i += colNo)
            {
                byte[] buffer = new byte[colNo];
                Buffer.BlockCopy(inputFile, i, buffer, 0, colNo);
                columnTrans[count] = buffer;
                countSize += colNo;
                count++;
            }

            byte[] finalRow = new byte[colNo + inputFile.Length % colNo];
            Buffer.BlockCopy(inputFile, countSize, finalRow, 0, finalRow.Length);
            columnTrans[rowNo - 1] = finalRow;

            for(int i = 0; i < columnTrans.Length;i++)
            {
                Array.Reverse(columnTrans[i]);
            }

            byte[] output = combineArrays(columnTrans);
            return output;

        }

        private byte[] combineArrays(byte[][] arrays)
        {
            try
            {
                int size = 0;
                int offset = 0;
                for (int i = 0; i < arrays.Length; i++)
                {
                    size += arrays[i].Length;
                }

                byte[] combined = new byte[size];

                foreach (byte[] file in arrays)
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
