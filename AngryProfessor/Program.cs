using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngryProfessor
{
    class Program
    {
        static void Main(string[] args)
        {
            int threshold = 2;
            int[] times = { 0, -1, 2, 1 };
            List<int> a = new List<int>(times);
            Console.WriteLine(angryProfessor(threshold, a));
        }
        public static string angryProfessor(int k, List<int> a)
        {
            string result;
            int cancelCounter = 0;
            foreach (int item in a)
            {
                if (item <= 0)
                {
                    cancelCounter++;
                }
            }
            if (cancelCounter < k)
            {
                result = "YES";
            }
            else
            {
                result = "NO";
            }

            return result;
        }
    }
}
