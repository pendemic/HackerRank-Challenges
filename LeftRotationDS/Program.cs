using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftRotationDS
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = 4;
            int[] integers = { 1, 2, 3, 4, 5 };
            List<int> arr = new List<int>(integers);
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(rotateLeft(d, arr)[i]);
            }
            
        }
        public static List<int> rotateLeft(int d, List<int> arr)
        {
            List<int> rotatedArr = new List<int>();
            int newIndex = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                newIndex = i + d;
                if (newIndex > arr.Count - 1)
                {
                    newIndex = newIndex - arr.Count;
                }
                rotatedArr.Add(arr[newIndex]);
            }
            return rotatedArr;

        }
    }
}
