using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerrankSolutions
{
    public class SparseArrays
    {

        public int[] matchingStrings(string[] strings, string[] queries)
        {
            List<int> counter = new List<int>(queries.Length);

            foreach (var query in queries)
            {
                counter.Add(strings.Where(x => x == query).Count());
            }
            return counter.ToArray();
        }

    }
}
