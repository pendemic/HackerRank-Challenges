using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SherlockAndSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 24, b = 49;
            Console.WriteLine(squares(a,b));
        }
        public static int squares(int a, int b)
        {
            int numSquares = 0;
            int counter = 1;
            double sq = 0;
            List<double> square = new List<double>();
            while (sq <= b)
            {
                sq = Math.Pow(counter, 2);
                square.Add(sq);
                counter++;
            }
            foreach (var item in square)
            {
                if (item >= a && item <= b)
                {
                    numSquares++;
                }
            }

            //for (int i = 0; i <= b; i++)
            //{
            //    if (Math.Pow(i,2) <= b && Math.Pow(i,2) >= a)
            //    {
            //        numSquares++;
            //    }
            //}

            return numSquares;
        }
    }
}
