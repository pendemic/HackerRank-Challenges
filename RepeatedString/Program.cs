using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatedString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "aba";
            long n = 10;
            Console.WriteLine(repeatedString(s,n));

        }
        public static long repeatedString(string s, long n)
        {
            long numLetters = 0;
            var infiniteString = new StringBuilder();
            char str = 'a';

            for (int i = 0; i <= n; i++)
            {
                infiniteString.Append(s[i % s.Count()]);
            }
            s = infiniteString.ToString();
            numLetters = s.Count(f => (f == str));

            return numLetters;
        }
    }
}
