using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulDayAtTheMovies
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 20, j = 23, k = 6;
            Console.WriteLine(beautifulDays(i,j,k));
        }
        public static int beautifulDays(int i, int j, int k)
        {
            int dayCounter = 0;
            string reverse;
            for (int l = i; l <= j; l++)
            {
                char[] charArray = l.ToString().ToCharArray();
                Array.Reverse(charArray);
                reverse = new string(charArray);
                if ((l - Int32.Parse(reverse)) % k == 0)
                {
                    dayCounter++;

                }
            }
            return dayCounter;
        }
    }
}
