using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLane
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 8;
            List<int> caseList = new List<int>();
            int[] widthList = { 2, 3, 1, 2, 3, 2, 3, 3 };
            List<int> width = new List<int>(widthList);
            int[] case1 = { 0, 3 }, case2 = { 4, 6 }, case3 = { 6, 7 }, case4 = { 3, 5 }, case5 = { 0, 7 };
            caseList.AddRange(case1);
            caseList.AddRange(case2);
            caseList.AddRange(case3);
            caseList.AddRange(case4);
            caseList.AddRange(case5);
            List<List<int>> cases = new List<List<int>>();
            List<int> solution = serviceLane(n, cases, width);
            for (int i = 0; i < solution.Count; i++)
            {
                Console.WriteLine(solution[i]);
            }
        }
        public static List<int> serviceLane(int n, List<List<int>> cases, List<int> width)
        {
            List<int> results = new List<int>();
            int count = 0;
            for (int j = 0; j < cases.Count; j++)
            {
                count++;
            }
            for (int i = 0; i < cases.Count; i++)
            {
                foreach (var item in cases)
                {
                    Console.WriteLine(cases.Count);
                }
            }
            Console.WriteLine(count);
            return results;
        }
    }
}
