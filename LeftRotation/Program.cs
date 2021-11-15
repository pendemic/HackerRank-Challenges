using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputArray = new List<int>();
            int[] arrayVal = { 1, 2, 3, 4, 5 };
            inputArray.AddRange(arrayVal);
            int numRotations = 4;
            List<int> solution = rotLeft(inputArray, numRotations);
            for (int i = 0; i < solution.Count; i++)
            {
                Console.WriteLine(solution[i]);
            }
        }
        public static List<int> rotLeft(List<int> a, int d)
        {
            List<int> rotatedList = new List<int>();
            int indexCounter = 0;
            for (int i = 0; i <= d; i++)
            {
                indexCounter++;
                if (indexCounter == 4)
                {
                    indexCounter = 0;
                }
                a[indexCounter + 1] = a[indexCounter];
                rotatedList.Add(a[indexCounter]);
            }

            return rotatedList;
        }
    }
}
