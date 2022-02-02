using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalWell
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2, n = 2;
            Console.WriteLine(solution(a,b,n));
        }
        public static int solution(int a, int b, int n)
        {
            int total = 0;

            for (int i = 0; i < n; i++)
            {
                total += a * b;
                a++;
                b++;
            }
            return total;
        }
    }
}
