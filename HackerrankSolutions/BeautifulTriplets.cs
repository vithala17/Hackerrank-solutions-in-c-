using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace HackerrankSolutions
{
    public class BeautifulTriplets
    {
        int count = 0;
        int x, y, z;

        public int beautifulTriplets(int d, int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr.Contains(arr[i] + d ) && arr.Contains(arr[i] + 2*d))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
