using System;
using System.Collections.Generic;

namespace LocarusTestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testData = Array.Empty<int>();
            var ds = discont(testData, 39, 1, 7);
            foreach (var variable in ds)
            {
                Console.WriteLine(variable);
            }
        }

        public static int[] discont(int[] number, int discount, int offset, int readLength)
        {
            int length = offset + readLength - 1;
            List<int> resultPrice = new List<int>();

            if (discount < 1 | discount > 99)
            {
                throw new Exception("incorrect discount");
            }
            
            if (readLength <= 0)
            {
                throw new Exception("incorrect readLength");
            }

            if (length > number.Length || offset < 0)
            {
                throw new Exception("Index out of range");
            }

            for (int i = offset; i <= length; i++)
            {
                if (number[i] > 0)
                {
                    resultPrice.Add((int)((float)number[i] - (float)number[i] / 100 * discount));
                }
            }

            return resultPrice.ToArray();
        }
    }
}