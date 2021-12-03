using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArr = { 3, 4, 5 };
            List<int> a = new List<int>(testArr);
            int numRotations = 1;
            int[] numQueries = { 1, 2 };
            List<int> queries = new List<int>(numQueries);
            List<int> solution = circularArrayRotation(a, numRotations, queries);
            for (int j = 0; j < queries.Count; j++)
            {
                Console.WriteLine(solution[queries[j]]);
            }
        }
        public static List<int> circularArrayRotation(List<int> a, int k, List<int> queries)
        {
            List<int> rotated = new List<int>(a);
            for (int i = 1; i <= k; i++)
            {
                k = k % a.Count;
                for (int j = rotated.Count - 1; j >= 0; j--)
                {
                    if (j == 0)
                    {
                        rotated[j] = a[a.Count - i];
                        break;
                    }
                    rotated[j] = rotated[j - 1];
                }
            }
            return rotated;
        }
    }
}
