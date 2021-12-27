using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigratoryBirds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] types = { 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4 };
            List<int> arr = new List<int>(types);
            Console.WriteLine(migratoryBirds(arr));
        }
        public static int migratoryBirds(List<int> arr)
        {
            int sightedBirds = 1;
            int typeBird;
            int indexMax;
            List<int> sortedarr = new List<int>(arr.OrderBy(i => i));
            List<int> distinctArr = new List<int>(sortedarr.Distinct());
            List<int> counts = new List<int>();
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = i+1; j < arr.Count; j++)
                {
                    if (sortedarr[i] == sortedarr[j])
                    {
                        sightedBirds++;
                    }
                }
                counts.Add(sightedBirds);
                sightedBirds = 1;
            }
            typeBird = counts.IndexOf(counts.Max());
            indexMax = distinctArr[typeBird];
            foreach (var item in counts)
            {
                Console.WriteLine(item);
            }

            return indexMax;
        }
    }
}
