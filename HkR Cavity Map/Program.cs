using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HkR_Cavity_Map
{
    class Program
    {
        static void Main(string[] args)
        {
            var sizeOfMap = int.Parse(Console.ReadLine());

            var map = new List<List<int>>();

            for (int i = 0; i < sizeOfMap; i++)
            {
                var inputLine = Console.ReadLine();
                var lineOfNumbers = new List<int>();
                foreach (var c in inputLine)
                {
                    lineOfNumbers.Add(int.Parse(c.ToString()));
                }
                map.Add(lineOfNumbers);
            }

            Console.Write("\n");

            for (int i = 1; i < map.Count - 1; i++)
            {
                var row = map[i];

                for (int j = 1; j < row.Count - 1; j++)
                {
                    var currentNum = row[j];
                    var leftNum = row[j - 1];
                    var rightNum = row[j + 1];
                    var upNum = map[i - 1][j];
                    var downNum = map[i + 1][j];

                    if (leftNum < currentNum && rightNum < currentNum
                        && upNum < currentNum && downNum < currentNum)
                    {
                        map[i][j] = 11;
                    }

                }
            }

            foreach (var row in map)
            {
                foreach (var i in row)
                {
                    if (i == 11)
                    {
                        Console.Write('X');
                    }
                    else
                    {
                        Console.Write(i);
                    }
                }
                Console.Write("\n");
            }

            Console.ReadKey();
        }
    }
}
