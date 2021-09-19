using System;
using System.Collections.Generic;
using System.Linq;

namespace KattisElection
{
    class Program
    {
        static void Main(string[] args)
        {

            // Dictionary<string, string> candidates = new Dictionary<string, string>();
            // Dictionary<string, string> parties = new Dictionary<string, string>();
            // Dictionary<int> votes = new Dictionary<int>();

            int N = Convert.ToInt32(Console.ReadLine());
            string[,] candidateArray = new string[N, 2];
            int i = 0;
            int j = 0;
            int indexRow = 0;

            while (i < N)
            {
                candidateArray[i, 0] = Console.ReadLine();
                candidateArray[i, 1] = Console.ReadLine();

                i += 1;
            }
            int M = Convert.ToInt32(Console.ReadLine());
            var votes = new List<String>();

            while (j < M)
            {
                votes.Add(Console.ReadLine());

                j += 1;
            }
            // I used the following link to help with line 37 https://stackoverflow.com/questions/7325278/group-by-in-linq
            var mostVotes = votes.GroupBy(k => k).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).Where(x => x != null).First();

            for (int l = 0; l < candidateArray.GetLength(0); ++l)
            {
                if (candidateArray[l, 0].Equals(mostVotes))
                    indexRow = l;
            }

            if (candidateArray[indexRow, 1] == null || candidateArray[indexRow, 1].Length == 0)
                Console.WriteLine("Independent");
            else
                Console.WriteLine(candidateArray[indexRow, 1]);

        }
    }
}


