using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingOnTheClouds
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> gameList = new List<int>();
            int [] clouds = { 0, 0, 0, 1, 0, 0};
            gameList.AddRange(clouds);
            Console.WriteLine(gameList);
            Console.WriteLine(jumpingOnClouds(gameList));
        }
        public static int jumpingOnClouds(List<int> c)
        {
            int numJumps = 0;
            int currentCloud = 0;
            int doubleCloud = 0;
            if (c.Count <= 1)
            {
                return 0;
            }

            while (currentCloud != (c.Count) - 1)
            {
                if (currentCloud + 2 < (c.Count) && c[currentCloud + 2] == doubleCloud )
                {
                    currentCloud += 2;
                }
                else
                {
                    currentCloud++;
                }
                numJumps++;
            }

            return numJumps;
        }
    }
}
