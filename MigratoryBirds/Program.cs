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
            int[] types = { 1, 4, 4, 4, 5, 3 };
            List<int> arr = new List<int>(types);
            Console.WriteLine(migratoryBirds(arr));
        }
        public static int migratoryBirds(List<int> arr)
        {
            //int sightedBirds = 1;
            //int typeBird;
            //int indexMax;
            //List<int> sortedarr = new List<int>(arr.OrderBy(i => i));
            //List<int> distinctArr = new List<int>(sortedarr.Distinct());
            //List<int> counts = new List<int>();
            //for (int i = 0; i < arr.Count; i++)
            //{
            //    for (int j = i+1; j < arr.Count; j++)
            //    {
            //        if (sortedarr[i] == sortedarr[j])
            //        {
            //            sightedBirds++;
            //        }
            //    }
            //    counts.Add(sightedBirds);
            //    sightedBirds = 1;
            //}
            //typeBird = counts.IndexOf(counts.Max());
            //indexMax = distinctArr[typeBird];
            //foreach (var item in counts)
            //{
            //    Console.WriteLine(item);
            //}

            //return indexMax;
            int sightedBirds = 0;
            int highestFreq;
            List<int> counts = new List<int>();
            for (int i = 1; i <= arr.Max(); i++)
            {
                for (int j = 0; j < arr.Count; j++)
                {
                    if (i == arr[j])
                    {
                        sightedBirds++;
                    }
                }
                counts.Add(sightedBirds);
                sightedBirds = 0;
            }
            highestFreq = (counts.IndexOf(counts.Max())) + 1;
            return highestFreq;
        }
    }
}
