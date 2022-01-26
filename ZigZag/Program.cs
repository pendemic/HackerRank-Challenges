using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZigZag
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 1, 3, 4 };
            
        }
        public static int[] solution(int[] numbers)
        {
            int[] solutionList = new int[numbers.Length - 2];
            int result = 0;
            for (int i = 0; i < numbers.Length - 2; i++)
            {
                if ((numbers[i] < numbers[i + 1] && numbers[i + 1] > numbers[i + 2]) ||
                    (numbers[i] > numbers[i + 1] && numbers[i + 1] < numbers[i + 2]))
                {
                    result = 1;
                    solutionList[i] = result;
                }
                else
                {
                    result = 0;
                    solutionList[i] = result;
                }
            }

            return solutionList;
        }
    }
}
