using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveThePrisoner
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5, m = 2, s = 1;
            Console.WriteLine(saveThePrisoner(n,m,s));
        }
        public static int saveThePrisoner(int n, int m, int s)
        {
            int remainingPrisoners = n - s + 1;

            if (m > remainingPrisoners)
            {
                s = 1;
                m -= remainingPrisoners;
                m = m % n;
            }

            if (m == 0)
                s = n;
            else
                s += m - 1;

            return s;

        }
    }
}
