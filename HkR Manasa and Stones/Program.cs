using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HkR_Manasa_and_Stones
{
    class Program
    {

        static void Main(string[] args)
        {
            var numOfTestCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfTestCases; i++)
            {
                var result = new List<long>();
                var numOfStones = int.Parse(Console.ReadLine());
                var a = int.Parse(Console.ReadLine());
                var b = int.Parse(Console.ReadLine());

                for (int j = 0; j <= numOfStones - 1; j++)
                {
                    var theNumberOfGod = j*a + (numOfStones - j - 1)*b;

                    if (!result.Contains(theNumberOfGod)) result.Add(theNumberOfGod);
                    
                }

                result.Sort();

                foreach (var i1 in result)
                {
                    Console.Write(i1 + " ");
                }
                Console.Write("\n");
            }
        }
    }
}
