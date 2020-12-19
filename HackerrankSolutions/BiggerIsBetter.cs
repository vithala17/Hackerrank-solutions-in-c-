using System;
using System.Collections.Generic;
using System.Text;

namespace HackerrankSolutions
{
    public class BiggerIsBetter
    {
        public string biggerIsGreater(string w)
        {
            List<int> array = new List<int>();
            foreach (char c in w)
            {
                array.Add((int)c);
            }

            return NextPermutation(array);
        }

        public string NextPermutation(List<int> array)
        {
            // Find non-increasing suffix
            int i = array.Count - 1;

            while (i > 0 && array[i - 1] >= array[i])
                i--;

            if (i <= 0)
                return "no answer";

            // Find successor to pivot
            int j = array.Count - 1;

            while (array[j] <= array[i - 1])
                j--;

            int temp = array[i - 1];
            array[i - 1] = array[j];
            array[j] = temp;

            // Reverse suffix
            j = array.Count - 1;
            while (i < j)
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                i++;
                j--;
            }

            string s = "";
            foreach (int element in array)
            {
                s += (char)element;
            }

            return s;
        }

    }
}
