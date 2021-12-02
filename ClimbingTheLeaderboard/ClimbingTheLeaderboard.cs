using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimbingTheLeaderboard
{
    class ClimbingTheLeaderboard
    {
        static void Main(string[] args)
        {
            int[] rankedList = { 100, 90, 90, 80, 75, 60};
            int[] playerList = { 50, 65, 77, 90, 102};
            List<int> ranked = new List<int>(rankedList);
            List<int> player = new List<int>(playerList);
            List<int> solution = climbingLeaderboard(ranked, player);
            foreach (var item in solution)
            {
                Console.WriteLine(item);
            }
            
        }
        public static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
        {
            List<int> newRank = new List<int>();
            List<int> noDuplicates = new List<int>(ranked.Distinct());
            int place = 0;
            for (int i = 0; i < player.Count; i++)
            {
                if (player[i] < noDuplicates.Min())
                {
                    place = noDuplicates.Count + 1;
                    newRank.Add(place);
                }
                else if (player[i] > noDuplicates.Max())
                {
                    place = 1;
                    newRank.Add(place);
                }
                for (int j = 0; j < noDuplicates.Count; j++)
                {
                    if (player[i] > noDuplicates[j])
                    {
                        place = j + 1;
                        newRank.Add(place);
                        break;
                    }
                    else if (player[i] == noDuplicates[j])
                    {
                        place = j + 1;
                        newRank.Add(place);
                        break;
                    }
                }
            }
            List<int> results = new List<int>(newRank.Distinct());
            return results;
        }
    }
}
