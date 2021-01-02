using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace HackerrankSolutions
{
    public class BeautifulDaysAtMovies
    {
        public int beautifulDays(int i, int j, int k)
        {
            int count = 0;

            for (int day = i; day <= j; day++)
            {
                char[] charArray = day.ToString().ToCharArray();
                int len = day.ToString().Length - 1;

                for (int m = 0; m < len; m++, len--)
                {
                    charArray[m] ^= charArray[len];
                    charArray[len] ^= charArray[m];
                    charArray[m] ^= charArray[len];
                }


                int reverseDay = Int32.Parse(new string(charArray));

                int dayDiff = day - reverseDay < 0 ? (day - reverseDay) * -1 : day - reverseDay;
                //Console.Write(day +"," +reverseDay+":"+ dayDiff);
                //Console.WriteLine();

                if (dayDiff % k == 0)
                    count++;

            }

            return count;
        }
    }
}
