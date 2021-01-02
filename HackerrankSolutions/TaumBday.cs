using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace HackerrankSolutions
{
    public class TaumBday
    {
        public BigInteger taumBday(int b, int w, int bc, int wc, int z)
        {
            return BigInteger.Multiply(b, Math.Min(bc, wc + z)) + BigInteger.Multiply(w, Math.Min(wc, bc + z));
        }
    }
}
