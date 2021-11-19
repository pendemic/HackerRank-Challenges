using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraLongFactorials
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 10;
            Console.WriteLine(extraLongFactorials(input));
        }
        public static long extraLongFactorials(int n)
        {
            long factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
