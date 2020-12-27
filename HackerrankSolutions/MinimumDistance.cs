using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace HackerrankSolutions
{
    public class box
    {
        public int val;
        public int ind;
    }

    public class MinimumDistance
    {
        public int minimumDistances(int[] a)
        {
            var arr = a.ToList<int>();

            List<box> duplicates = a.Select((x, i) => new box { val = x, ind = i })
                            .Where(x => (a.GroupBy(i => i).Where(g => g.Count() > 1).Select(g => g.Key).ToList()).Contains(x.val)).ToList<box>();



            return 0;
        }
    }
}
