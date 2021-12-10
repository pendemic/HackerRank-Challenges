using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFine
{
    class Program
    {
        static void Main(string[] args)
        {
            int d1 = 9, m1 = 6, y1 = 2015, d2 = 6, m2 = 6, y2 = 2015;
            Console.WriteLine(libraryFine(d1,m1,y1,d2,m2,y2));
        }
        public static int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
        {
            int fee = 0;
            if (y1 > y2)
            {
                return 10000;
            }
            else if (y1 < y2)
            {
                return 0;
            }
            if (d1 > d2)
            {
                fee = 15 * (d1 - d2);

            }
            else if (m1 > m2)
            {
                fee = 500 * (m1 - m2); ;
            }
            else
            {
                return 0;
            }

            return fee;
        }
    }
}
