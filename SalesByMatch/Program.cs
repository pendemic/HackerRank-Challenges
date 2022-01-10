using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesByMatch
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> g = new List<int>();
            int[] socks = { 10, 20, 30, 30, 10 };
            g.AddRange(socks);
            Console.WriteLine(sockMerchant(5, g));

        }
        public static int sockMerchant(int n, List<int> ar)
        {
            int numPairs = 0;
            Dictionary<int, int> d = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                if (d.ContainsKey(ar[i]))
                {
                    d[ar[i]] += 1;
                }
                else
                {
                    d[ar[i]] = 1;
                }
            }
            foreach (var item in d.Values)
            {
                numPairs += item / 2;
            }
            return numPairs;

        }
    }
}
