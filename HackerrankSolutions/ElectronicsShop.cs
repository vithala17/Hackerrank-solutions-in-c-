using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace HackerrankSolutions
{
    public class ElectronicsShop
    {
        public int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            Array.Sort(keyboards);
            Array.Reverse(keyboards);
            Array.Sort(drives);
            Array.Reverse(drives);

            List<int> expenditures = new List<int>();

            foreach (var kboard in keyboards)
            {
                foreach (var drive in drives)
                {
                    if (b >= kboard + drive)
                    {
                        expenditures.Add(kboard + drive);
                    }
                }
            }

            if (expenditures.Count != 0)
                return expenditures.Max();
            else
                return -1;
        }
    }
}
