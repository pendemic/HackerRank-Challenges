using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestContiguousArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 1, 5, 1, 2 };
            int[] b = { 4, 3 };
            int[] c = { 2, 1 };
            Console.WriteLine(solution(a,b,c));
        }
        public static bool solution(int[] a, int[] b, int[] c)
        {
            bool result = true;
            bool inCommon = c.Intersect(b).Count() <= c.Count();
            Console.WriteLine(inCommon);
            return result;
        }
    }
}
