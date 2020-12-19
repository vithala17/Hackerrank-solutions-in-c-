using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace HackerrankSolutions
{
    public class ExtraLongFactorials
    {
        public BigInteger extraLongFactorials(int n)
        {
            BigInteger bigInteger = 1;

            for (int i = n; i > 0; i--)
            {
                bigInteger = bigInteger * i;
            }


            return bigInteger;
        }
    }
}
