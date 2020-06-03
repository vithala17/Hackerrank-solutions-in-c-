using System;
using System.Collections.Generic;
using System.Text;

namespace HackerrankSolutions
{
    public class DrawingBook
    {
        public int pageCount(int n, int p)
        {
            return Math.Min(p / 2, (n / 2 - p / 2));
        }
    }
}