using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace HackerrankSolutions
{
    public class PDFdesigner
    {
        public int designerPdfViewer(int[] h, string word)
        {
            List<int> AlphabetDirectory = new List<int>();

            foreach (char alphabet in word)
            {
                AlphabetDirectory.Add(h[(int)alphabet - 97]);
            }

            return AlphabetDirectory.Max() * word.Count();
        }
    }
}
