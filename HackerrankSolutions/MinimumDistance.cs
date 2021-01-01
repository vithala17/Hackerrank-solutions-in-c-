using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace HackerrankSolutions
{

    // Incomplete yet to be submitted

    public class box
    {
        public int val;
        public int ind;
    }

    public class MinimumDistance
    {
        public int minimumDistances(int[] a)
        {
            int diff = Int16.MaxValue;
            var arr = a.ToList<int>();
            List<int> mins = new List<int>();

            List<box> duplicatesWithIndices = (a.Select((x, i) => new box { val = x, ind = i })
                            .Where(x => (a.GroupBy(i => i).Where(g => g.Count() > 1).Select(g => g.Key).ToList()).Contains(x.val)).ToList<box>()).OrderBy(x => x.val).ToList();

            List<List<int>> collectiveIndices = new List<List<int>>();
            for (int i = 0; i < duplicatesWithIndices.Count; i++)
            {
                //List<int> indices = new List<int>();
                for (int j = i; j < duplicatesWithIndices.Count; j++)
                {
                    if (duplicatesWithIndices[i].val == duplicatesWithIndices[j].val)
                    {
                        //indices.Add(duplicatesWithIndices[j].ind);
                        //if (diff > duplicatesWithIndices[j].ind - duplicatesWithIndices[i].ind)
                        //{
                        //    diff = duplicatesWithIndices[j].ind - duplicatesWithIndices[i].ind;
                        //}
                    }
                    else
                    {
                        break;
                    }
                }
                //indices.Sort();
                //collectiveIndices.Add(indices);
            }

            if (diff == Int16.MaxValue)
            {
                diff = -1;
            }

            return diff;
        }

        public int minimumDistancesUsingDictionary(List<int> a)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            List<box> duplicatesWithIndices = (a.Select((x, i) => new box { val = x, ind = i })
                            .Where(x => (a.GroupBy(i => i).Where(g => g.Count() > 1).Select(g => g.Key).ToList()).Contains(x.val)).ToList<box>()).OrderBy(x => x.val).ToList();


            dict = duplicatesWithIndices.Select((x, y) => new { x.val, x.ind }).ToDictionary(pair => pair.ind, pair => pair.val);

            List<int> ls = null;
            foreach (KeyValuePair<int, int> item in dict)
            {
                Console.WriteLine(item.Key + ", " + item.Value);
            }

            return 0;
        }
    }
}

// (value, index) => new { value, index }