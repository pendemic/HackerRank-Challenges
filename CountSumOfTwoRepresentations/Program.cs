using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSumOfTwoRepresentations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 93, l = 24, r = 58;
            Console.WriteLine(solution(n,l,r));
        }
        public static int solution(int n, int l, int r)
        {
            //int numWays = 0;
            //for (int i = l; i <= r; i++)
            //{
            //    for (int j = r; j >= l; j--)
            //    {
            //        if (i + j == n && i <= j)
            //        {
            //            numWays++;
            //        }
            //    }
            //}

            //return numWays;

            int numWays = 0;
            for (int i = l; i < n; i++)
            {
                if (i + r == n && i <= r)
                {
                    numWays++;
                    r--;
                }
            }

            return numWays;
        }
    }
}
