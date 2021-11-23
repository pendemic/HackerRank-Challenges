using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatsAndMouse
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            int y = 5;
            int z = 4;
            Console.WriteLine(catAndMouse(x,y,z));
        }
        static string catAndMouse(int x, int y, int z)
        {
            string catA = "Cat A";
            string catB = "Cat B";
            string mouseC = "Mouse C";
            int aDist = x - z;
            int bDist = y - z;
            if (aDist < 0)
            {
                aDist = aDist * -1;
            }
            if (bDist < 0)
            {
                bDist = bDist * -1;
            }
            if (aDist < bDist)
            {
                return catA;
            }
            else if (aDist == bDist)
            {
                return mouseC;
            }
            else
            {
                return catB;
            }
        }
    }
}
