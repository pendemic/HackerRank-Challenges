using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateFeast
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 6, c = 2, m = 2;
            Console.WriteLine(chocolateFeast(n,c,m));
        }
        public static int chocolateFeast(int n, int c, int m)
        {
            int chocolatesAte = n/c;
            int wrappersToTurn = chocolatesAte / m;
            int wrappers = chocolatesAte % m;
            for (int i = wrappersToTurn; i > 0; i/=m)
            {
                
                chocolatesAte += i;
                i += wrappers;
                wrappers = i % m;

            }

            return chocolatesAte;
        }

    }
}
