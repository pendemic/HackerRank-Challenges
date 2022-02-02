using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeastFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 17;
            Console.WriteLine(solution(n));
        }
        public static int solution(int n)
        {
            int factorialSum = 1;
            for (int i = 1; i < n; i++)
            {
                factorialSum *= i;
                if (factorialSum > n)
                {
                    return factorialSum;
                }
            }
            return factorialSum;
        }
    }
}
