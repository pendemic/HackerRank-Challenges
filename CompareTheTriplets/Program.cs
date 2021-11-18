using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTheTriplets
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listA = { 17, 28, 30 };
            int[] listB = { 99, 16, 8 };
            List<int> a = new List<int>(listA);
            List<int> b = new List<int>(listB);
            List<int> solution = compareTriplets(a, b);
            for (int i = 0; i < solution.Count; i++)
            {
                Console.WriteLine(solution[i]);
            }
        }
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int[] initialScore = { 0, 0 };
            List<int> score = new List<int>(initialScore);
            int bobScore = 0;
            int aliceScore = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] < b[i])
                {
                    score[1] = bobScore++;
                }
                else if (a[i] > b[i])
                {
                    score[0] = aliceScore++;
                }
            }
            score[0] = aliceScore;
            score[1] = bobScore;
            return score;
        }
    }
}
