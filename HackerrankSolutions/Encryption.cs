using System;
using System.Collections.Generic;
using System.Text;

namespace HackerrankSolutions
{

    // https://www.hackerrank.com/challenges/encryption/problem

    public class Encryption
    {
        public string encryption(string s)
        {
            // 0 1 2 3 4 5 6 7 8 9
            // f e e d t h e d o g

            // fto ehg ee dd
            // 048 159 26 37

            StringBuilder answer = new StringBuilder();

            var count = s.Length;
            var root = Math.Sqrt(count);

            var rows = (int)Math.Ceiling(root); // 4
            var columns = (int)Math.Floor(root); // 3

            //for (int m = 0; m <= rows; m++)
            //{
            //    for (int n = m; n < count; n = n + rows)
            //        Console.Write(s[n]);
            //    Console.Write(' ');
            //}

            for (int j = 0; j <= columns; ++j)
            {
                for (int i = j; i < count; i += rows)
                    answer.Append(s[i]);
                answer.Append(' ');
            }

            return answer.ToString().Trim();
        }
    }
}
