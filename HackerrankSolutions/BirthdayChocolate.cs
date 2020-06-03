using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankProblems
{
    public class BirthdayChocolate
    {
        public int birthday(List<int> s, int d, int m)
        {
            int sum, counter = 0;

            for (int i = 0; i < s.Count - m; i++)
            {
                sum = 0;
                for (int j = 0; j < m; j++)
                {
                    sum += sum + s[i+j];
                }

                if (sum == d)
                    counter++;
            }

            return counter;
        }
    }
}
