using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace HackerrankSolutions
{
    public class HurdleRace
    {
        public int hurdleRace(int k, int[] height)
        {
            var heightList = height.ToList();
            if (heightList.Max() > k)
                return heightList.Max() - k;
            else
                return 0;
        }
    }
}
