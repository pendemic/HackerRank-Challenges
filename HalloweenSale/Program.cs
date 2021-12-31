using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloweenSale
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = 20, d = 3, m = 6, s = 80;
            Console.WriteLine(howManyGames(p,d,m,s));
        }
        public static int howManyGames(int p, int d, int m, int s)
        {
            int numGames = 0;
            int newPrice = p;
            for (int i = p; i <= s; i+=newPrice)
            {
                newPrice -= d;
                if (newPrice <= m)
                {
                    newPrice = m;
                }
                numGames++;
            }

            return numGames;

        }
    }
}
