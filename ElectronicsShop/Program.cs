using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicsShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = 10;
            int[] keyboards = { 3, 1};
            int[] drives = { 5, 2, 8 };
            Console.WriteLine(getMoneySpent(keyboards, drives, budget));
        }
        static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            int maxCost = 0;
            int total = 0;
            int minCost = keyboards.Min() + drives.Min();
            if (minCost > b)
            {
                return -1;
            }
            for (int i = 0; i < keyboards.Length; i++)
            {
                for (int j = 0; j < drives.Length; j++)
                {
                    total = keyboards[i] + drives[j];
                    if (total > maxCost && total <= b)
                    {
                        maxCost = total;
                    }
                }
            }

            return maxCost;

        }
    }
}
