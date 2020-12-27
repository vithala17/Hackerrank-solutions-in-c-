using System;
using System.Linq;
using System.Collections.Generic;
using HackerrankSolutions;

namespace HakcerrankSolution_DebugConsole
{
    public class box
    {
        public int index;
        public int value;
    }
 
    class Program
    {
        static void Main(string[] args)
        {
            var data = new List<int> { 36, 2, 43, 0, 0, 36 };
            
            var dupes = data.Select((x, i) => new box { value = x, index = i })
                            .Where(x => (data
                                           .GroupBy(i => i)
                                           .Where(g => g.Count() > 1)
                                           .Select(g => g.Key).ToList()
                                         ).Contains(x.value));

            foreach (var item in dupes)
            {
                Console.WriteLine(item.value +";"+item.index);
            }
        }
    }
}
