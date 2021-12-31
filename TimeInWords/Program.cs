using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeInWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = 1, m = 1;
            Console.WriteLine(timeInWords(h,m));
        }
        public static string timeInWords(int h, int m)
        {
            int past = 60 - m;
            string[] hours = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve" };
            string[] minutes = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "quarter", "sixteen", "seventeen", "eighteen", "nineteen", "twenty", "twenty one", "twenty two", "twenty three", "twenty four", "twenty five", "twenty six", "twenty seven", "twenty eight", "twenty nine", "half" };
            string[] times = { "o' clock", "past", "to" };
            string time = "";
            if (m == 0)
            {
                time = hours[h] + " " + times[0];
            }
            else if (m == 15 || m == 30)
            {
                time = minutes[m] + " " + times[1] + " " + hours[h];
            }
            else if (m == 45)
            {
                time = minutes[past] + " " + times[2] + " " + hours[h + 1];
            }
            else if (m == 1)
            {
                time = minutes[m] + " minute " + times[1] + " " + hours[h];
            }
            else if (m > 1 && m <= 30)
            {
                time = minutes[m] + " minutes " + times[1] + " " + hours[h];
            }
            else
            {
                time = minutes[past] + " minutes " + times[2] + " " + hours[h + 1];
            }

            return time;
        }
    }
}
