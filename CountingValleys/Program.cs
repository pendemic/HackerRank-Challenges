using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingValleys
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = 8;
            string path = "UDDDUDUU";
            Console.WriteLine(countingValleys(steps, path));
        }
        public static int countingValleys(int steps, string path)
        {
            int numValleys = 0;
            int altitudeCounter = 0;
            bool isInValley = false;
            for (int i = 0; i < path.Length; i++)
            {
                if (path[i].Equals('U'))
                {
                    altitudeCounter++;
                    if (isInValley = true && altitudeCounter == 0)
                    {
                        numValleys++;
                        isInValley = false;
                    }
                }
                else
                {
                    altitudeCounter--;
                    if (altitudeCounter >= 0)
                    {
                        isInValley = false;
                    }
                    else
                    {
                        isInValley = true;
                    }
                }
            }

            return numValleys;
        }
    }
}
