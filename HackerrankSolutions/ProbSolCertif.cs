using System;
using System.Linq;
using System.Collections.Generic;

namespace HackerrankSolutions
{
    public class ProbSolCertif
    {
        public List<int> stringAnagram(List<string> dictionary, List<string> query)
        {
            query = query.Select(x => String.Join("", x.ToCharArray().OrderBy(y => y))).ToList();
            dictionary = dictionary.Select(x => String.Join("", x.ToCharArray().OrderBy(y => y))).ToList();

            List<int> anagramCount = new List<int>();
            foreach(var item in query)
                anagramCount.Add(dictionary.FindAll(x => String.Equals(x, item)).Count);

            return anagramCount;
        }

        bool areAngram(string str1, string str2)
        {
            //    int NO_OF_CHARS = 256;
            //    int[] count = new int[256];
            //    int i;

            //    // For each character in input strings, increment count in 
            //    // the corresponding count array 
            //    for (i = 0; str1[i] && str2[i]; i++)
            //    {
            //        count[str1[i]]++;
            //        count[str2[i]]--;
            //    }

            //    // If both strings are of different length. Removing this condition 
            //    // will make the program fail for strings like "aaca" and "aca" 
            //    if (str1[i] || str2[i])
            //        return false;

            //    // See if there is any non-zero value in count array 
            //    for (i = 0; i < NO_OF_CHARS; i++)
            //        if (count[i])
            //            return false;
            return true;
        }
    }
}
