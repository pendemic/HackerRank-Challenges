using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 };
            int[] b = { 3, 2, 1 };
            int k = 12;
            Console.WriteLine(solution(a,b,k));

        }
        public static int solution(int[] a, int[] b, int k)
        {
            int tiny = 0;
            int counter = 0;
            int[] reversedB = new int[b.Length];
            string strA;
            string strB;
            string strK;
            for (int i = 0; i < b.Length; i++)
            {
                reversedB[counter] = b[i];
                counter++;
            }
            for (int j = 0; j < a.Length; j++)
            {
                strA = a[j].ToString();
                strB = reversedB[j].ToString();
                strK = strA + strB;
                if (Int32.Parse(strK) < k)
                {
                    tiny++;
                }
            }
            return tiny;
        }
    }
}
