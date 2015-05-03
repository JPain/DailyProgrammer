using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HkR_ACM_ICPC_Team
{
    class Program
    {
        static void Main(string[] args)
        {
            var line1 = Console.ReadLine().Split(' ');
            var numPeople = int.Parse(line1[0]);
            var numTopics = int.Parse(line1[1]);

            var people = new List<BitArray>();

            for (int i = 0; i < numPeople; i++)
            {
                var bitArray = new BitArray(numTopics);

                var inputTopics = Console.ReadLine();
                for (int j = 0; j < inputTopics.Length; j++)
                {
                    bitArray[j] = (int.Parse(inputTopics[j].ToString())) == 1;
                }

                people.Add(bitArray);
            }

            //ABOVE IS SOLID

            var knownTopics = new List<int>();
            var maxTopics = 0;

            for (int i = 0; i < people.Count; i++)
            {
                var compareFrom = people[i];
                for (int j = i + 1; j < people.Count; j++)
                {
                    var compareTarget = people[j];
                    var count = 0;

                    for (int k = 0; k < numTopics; k++) if (compareFrom[k] || compareTarget[k]) count++;

                    knownTopics.Add(count);
                    if (count > maxTopics) maxTopics = count;
                }
            }

            var maxTeams = knownTopics.Count(i => i.Equals(maxTopics));

            Console.WriteLine(maxTopics);
            Console.WriteLine(maxTeams);
        }
    }
}
