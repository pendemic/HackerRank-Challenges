using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMICPCTeam
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] topics = { "10101", "11110", "00010" };
            List<string> topic = new List<string>(topics);
            List<int> solution = acmTeam(topic);
            for (int i = 0; i < solution.Count; i++)
            {
                Console.WriteLine(solution[i]);
            }
        }
        public static List<int> acmTeam(List<string> topic)
        {
            List<int> results = new List<int>();
            List<int> placeholder = new List<int>();
            int numTeams = 0;
            int maxTopics = topic[0].Length;
            int numTopics = 0;
            foreach (var item in topic)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    for (int j = 0; j < item.Length; j++)
                    {
                        if (i == j)
                        {
                            break;
                        }
                        for (int k = 0; k < item.Length; k++)
                        {
                            placeholder[k] = item[i] + item[j];
                            if (placeholder[k] > 0 )
                            {
                                numTopics++;
                            }
                        }
                    }
                }
                results.Add(numTopics);
            }
            
            results.Add(numTeams);

            return results;
        }
    }
}
