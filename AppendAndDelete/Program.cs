using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendAndDelete
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "ashley";
            string t = "ash";
            int k = 2;
            Console.WriteLine(appendAndDelete(s,t,k));
        }
        public static string appendAndDelete(string s, string t, int k)
        {
            int length = 0;
            int numOp = 0;
            var l = new StringBuilder();
            if (s.Length < t.Length)
            {
                length = s.Length;
            }
            else
            {
                length = t.Length;
            }
            for (int i = 0; i < length; i++)
            {
                if (s[i] == t[i])
                {
                    l.Append(s[i]);
                    numOp = s.Length - (i + 1);
                }
                else
                {
                    numOp = (s.Length - (l.ToString().Length)) + (t.Length - (l.ToString().Length));
                    break;
                }
            }
            if (numOp <= k)
            {
                Console.WriteLine(numOp);
                return "Yes";
            }
            else
            {
                Console.WriteLine(numOp);
                return "No";
            }
        }

    }
}
