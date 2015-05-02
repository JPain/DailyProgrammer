// https://www.hackerrank.com/challenges/service-lane
// Service Lane - Hacker Rank
// James Pain

using System;
using Utilities;

namespace HkR_Service_Lane
{
    class Program
    {
        static void Main(String[] args)
        {
            var line1 = Console.ReadLine();
            var line1Split = line1.Split(' ');
            var numOfTestCases = int.Parse(line1.Split(' ')[1]);

            var line2 = Console.ReadLine();
            var laneWidths = line2.Split(' ');


            for (var i = 1; i <= numOfTestCases; i++)
            {

                var input = Console.ReadLine();
                var inputSplit = input.Split(' ');

                var entrySeg = int.Parse(inputSplit[0]);
                var exitSeg = int.Parse(inputSplit[1]);

                var minWidth = 3;

                for (var f = entrySeg; f <= exitSeg; f++)
                {
                    var laneWidth = int.Parse(laneWidths[f]);
                    if (laneWidth < minWidth)
                    {
                        minWidth = laneWidth;
                    }
                }

                Console.WriteLine(minWidth);

            }

        }
    }
}
