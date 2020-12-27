using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace HackerrankSolutions
{
    public class ModifiedKaprekarNumber
    {
        public void kaprekarNumbers(int p, int q)
        {
            int counter = 0;
            for (long i = p; i <= q; i++)
            {
                var square = (i * i).ToString();

                int firstPart = 0, secondPart = 0;

                if (!String.IsNullOrEmpty(square.Substring(0, (square.Length / 2))))
                    firstPart = int.Parse(square.Substring(0, (square.Length / 2)));
                
                    secondPart = int.Parse(square.Substring(square.Length / 2));

                if (firstPart + secondPart == i)
                {
                    Console.Write(i + " ");
                    counter++;
                }
            }

            if (counter == 0)
                Console.WriteLine("INVALID RANGE");
        }
    }
}