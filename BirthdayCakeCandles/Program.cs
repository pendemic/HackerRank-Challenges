using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCakeCandles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 4, 4, 1, 3 };
            List<int> candles = new List<int>(input);
            Console.WriteLine(birthdayCakeCandles(candles));
        }
        public static int birthdayCakeCandles(List<int> candles)
        {
            int count = 0;
            int max = candles.Max();
            foreach (var item in candles)
            {
                if (item == max)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
