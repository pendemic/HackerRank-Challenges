using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lisa_sWorkbook
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10, k = 5;
            int[] arrList = { 3, 8, 15, 11, 14, 1, 9, 2, 24, 31 };
            List<int> arr = new List<int>(arrList);

            Console.WriteLine(workbook(n, k, arr));
        }
        public static int workbook(int n, int k, List<int> arr)
        {
            int specialCounter = 0;
            int pageNum = 1;
            foreach (var item in arr)
            {
                int pages = item / k;
                for (int j = pages; j > 0; j/=k)
                {
                    pageNum++;
                }
                for (int i = 1; i <= item; i++)
                {
                    if (pageNum == i)
                    {
                        specialCounter++;
                    }
                }

                if (item % k > 0)
                {
                    pageNum += 1;
                }
                Console.WriteLine(pageNum);
            }
            
            return specialCounter;
        }
    }
}
