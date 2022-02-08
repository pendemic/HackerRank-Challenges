using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lineup
{
    class Program
    {
        static void Main(string[] args)
        {
            string commands = "LLARL";

            Console.WriteLine(solution(commands));
        }
        public static int solution(string commands)
        {
            int count = 0;
            int sStudent = 0;
            int dStudent = 0;

            foreach (char item in commands)
            {
                if (item == 'L')
                {
                    sStudent = (sStudent + 1) % 4;
                    dStudent = (dStudent + 3) % 4;
                }
                else if (item == 'R')
                {
                    sStudent = (sStudent + 3) % 4;
                    dStudent = (dStudent + 1) % 4;
                }
                else if (item == 'A')
                {
                    sStudent = (sStudent + 2) % 4;
                    dStudent = (dStudent + 2) % 4;
                }
                if (sStudent == dStudent)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
