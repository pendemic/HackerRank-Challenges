using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViralAdvertising
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            Console.WriteLine(viralAdvertising(n));
        }
        public static int viralAdvertising(int n)
        {
            int totalLikes = 0;
            int likes = 0;
            int shared = 5;
            for (int i = 0; i < n; i++)
            {
                likes = shared / 2;
                totalLikes += likes;
                shared = (shared / 2) * 3;
            }

            return totalLikes;
        }
    }
}
