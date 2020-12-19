using System;
using System.Collections.Generic;
using System.Text;

namespace HackerrankSolutions
{
    public class BetweenTwoSets
    {
        public static int getTotalX(List<int> a, List<int> b)
        {
            int count = 0;

            int lcm = getLCM(a);
            int gcd = getGCD(b);

            for (int i = lcm, j = 2; i <= gcd; i = lcm * j, j++)
            {
                if (gcd % i == 0)
                    count++;
            }
            return count;
        }

        static int getLCM(List<int> input)
        {
            int result = input[0];
            for (int i = 1; i < input.Count; i++)
            {
                result = Lcm(result, input[i]);
            }
            return result;
        }

        static int getGCD(List<int> input)
        {
            int result = input[0];
            for (int i = 1; i < input.Count; i++)
            {
                result = Gcd(result, input[i]);
            }
            return result;
        }

        static int Lcm(int a, int b)
        {
            return (a * b) / Gcd(a, b);
        }

        static int Gcd(int a, int b)
        {
            while (b > 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}
