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
            List<string> days = new List<string>();
            List<string> reversedDays = new List<string>();
            for (int l = i; l <= j; l++)
            {
                days.Add(l.ToString());
            }
            foreach (var item in days)
            {
                char[] charArray = item.ToCharArray();
                Array.Reverse(charArray);
                reverse = new string(charArray);
                reversedDays.Add(reverse);
            }
            for (int m = 0; m < days.Count; m++)
            {
                if ((Int32.Parse(days[m]) - Int32.Parse(reversedDays[m])) % k == 0)
                {
                    dayCounter++;
                    
                }
            }
            return dayCounter;
        }
    }
}
