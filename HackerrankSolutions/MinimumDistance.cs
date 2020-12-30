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
            int diff = Int16.MaxValue ;
            var arr = a.ToList<int>();
            List<int> mins = new List<int>();

            List<box> duplicatesWithIndices = (a.Select((x, i) => new box { val = x, ind = i })
                            .Where(x => (a.GroupBy(i => i).Where(g => g.Count() > 1).Select(g => g.Key).ToList()).Contains(x.val)).ToList<box>()).OrderBy(x => x.val).ToList();

            //foreach (var item in duplicatesWithIndices)
            //{
            //    Console.WriteLine(item.val + "," + item.ind);
            //}

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < duplicatesWithIndices.Count; i++)
            {
                for (int j = i + 1; j < duplicatesWithIndices.Count - 1; j++)
                {
                    if (duplicatesWithIndices[i].val == duplicatesWithIndices[j].val)
                    {
                        if (diff > duplicatesWithIndices[j].ind - duplicatesWithIndices[i].ind)
                        {
                            diff = duplicatesWithIndices[j].ind - duplicatesWithIndices[i].ind;
                        }
                    }
                    else
                        break;
                }
            }

            if (diff == Int16.MaxValue)
            {
                diff = -1;
            }

            return diff;
        }
    
        public int minimumDistancesUsingDictionary(int[] a)
        {
            KeyValuePair<int, int> kp = new KeyValuePair<int, int>();

            //List<kp> duplicatesWithIndices = (a.Select((x, i) => new { x, i })
            //                .Where(x => (a.GroupBy(i => i).Where(g => g.Count() > 1).Select(g => g.Key).ToList()).Contains(x)).ToList<box>()).OrderBy(x => x).ToList();

            Dictionary<int, int> dupeDict = new Dictionary<int, int>((a.Select((x, i) => new { x, i })
                            .Where(x => (a.GroupBy(i => i).Where(g => g.Count() > 1).Select(g => g.Key).ToList()).Contains(x)).ToList<box>()).OrderBy(x => x));

            return 0;
        }
    }
}