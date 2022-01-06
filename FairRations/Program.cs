using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairRations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 2, 3, 4, 5, 6 };
            List<int> B = new List<int>(list);
            Console.WriteLine(fairRations(B));
        }
        public static string fairRations(List<int> B)
        {
            string result;
            int counter = 0;
            int even = 2;
            for (int i = B.Count - 1; i >= 0; i--)
            {
                if (i == 0 && B[i] % even == 1)
                {
                    return "NO";
                }
                if (B[i] % even == 1)
                {
                    B[i] = B[i] + 1;
                    B[i - 1] = B[i - 1] + 1;
                    counter += 2;
                }
            }
            result = counter.ToString();
            return result;

        }
    }
}
