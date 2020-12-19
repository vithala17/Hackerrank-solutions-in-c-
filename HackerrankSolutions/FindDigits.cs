using System;
using System.Collections.Generic;
using System.Text;

namespace HackerrankSolutions
{
    public class FindDigits
    {
        public int findDigits(int n)
        {
            int digit = 0, m = n, count = 0;
            List<int> array = new List<int>();
            while (m > 0)
            {
                digit = m % 10;

                if (digit != 0 && n % digit == 0)
                    count++;

                m = m / 10;
            }

            return count;
        }
    }
}
