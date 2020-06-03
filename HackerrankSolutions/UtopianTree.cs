using System;
using System.Collections.Generic;
using System.Text;

namespace HackerrankSolutions
{
    public class UtopianTree
    {
        public int utopianTree(int n)
        {
            return ~(~1 << (n >> 1)) << (n & 1);
        }
    }
}
