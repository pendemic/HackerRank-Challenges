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
            int [] clouds = { 1, 0, 0, 0, 0, 0};
            gameList.AddRange(clouds);
            Console.WriteLine(jumpingOnClouds(gameList));
        }
        public static int jumpingOnClouds(List<int> c)
        {
            int numJumps = 0;
            for (int i = 0; i < c.Count; i++)
            {
                if (c[i] == 0)
                {
                    i++;
                    numJumps++;
                }
                else if (c[i + 1] == 0)
                {
                    i++;
                    numJumps++;
                }
                else if (c[i] == 1)
                {
                    i = i - 2;
                    numJumps--;
                }
            }

            return numJumps;
        }
    }
}
