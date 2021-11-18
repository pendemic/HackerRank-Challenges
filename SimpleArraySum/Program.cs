using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sumList = new List<int>();
            int[] numbers = { 1, 2, 3, 4, 10, 11 };
            sumList.AddRange(numbers);
            Console.WriteLine(simpleArraySum(sumList));
        }
        public static int simpleArraySum(List<int> ar)
        {
            int sumArray = 0;
            for (int i = 0; i < ar.Count; i++)
            {
                sumArray += ar[i];
            }

            return sumArray;
        }
    }
}
