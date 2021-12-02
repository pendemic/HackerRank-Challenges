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
            for (int l = i; l <= j; l++)
            {
                var reverseDays = new string(l.ToString().Reverse().ToArray());
                if ((l - Int32.Parse(reverseDays)) % k == 0)
                {
                    dayCounter++;

                }
            }
            return dayCounter;
        }
    }
}
