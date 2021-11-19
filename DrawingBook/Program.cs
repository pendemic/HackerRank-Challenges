using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingBook
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPages = 5;
            int pageNum = 3;
            Console.WriteLine(pageCount(numPages,pageNum));
        }
        public static int pageCount(int n, int p)
        {
            int leftCount = (p) / 2;
            int rightCount = (n - p) / 2;
            return leftCount < rightCount ? leftCount : rightCount;
        }
    }
}
