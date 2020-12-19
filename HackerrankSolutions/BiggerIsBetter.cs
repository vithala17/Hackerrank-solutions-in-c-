using System;
using System.Collections.Generic;
using System.Text;

namespace HackerrankSolutions
{
    public class BiggerIsBetter
    {
        public string biggerIsGreater(string w)
        {
            //List<int> asciiValues = new List<int>();

            //foreach (char alphabet in w)
            //    asciiValues.Add((int)alphabet);

            foreach (char alphabet in w)
            {

            }

            return null;
        }

        public class nextperm
        {
            /* 
			 1. Computes the next lexicographical permutation of the given array
			 2. of integers in place, returning whether a next permutation existed.
			 3. (Returns false when the argument is already the last possible permutation.)
			 */
            public static bool NextPermutation(int[] array)
            {
                // Find non-increasing suffix
                int i = array.Length - 1;
               
                while (i > 0 && array[i - 1] >= array[i])
                    i--;
                
                if (i <= 0)
                    return false;

                // Find successor to pivot
                int j = array.Length - 1;
                
                while (array[j] <= array[i - 1])
                    j--;
                
                int temp = array[i - 1];
                array[i - 1] = array[j];
                array[j] = temp;

                // Reverse suffix
                j = array.Length - 1;
                while (i < j)
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
                return true;
            }

        }
    }
}
