using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulDayAtTheMovies
{
    public class BeautifulDay
    {
        static void Main(string[] args)
        {

        }
        public int beautifulDays(int i, int j, int k)
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
