using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HkR_Find_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            var numOfTestCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfTestCases; i++)
            {
                var line1 = Console.ReadLine();
                var input = long.Parse(line1);

                var numList = new List<long>();

                foreach (var c in line1)
                {
                    if (long.Parse(c.ToString()) != 0) numList.Add(long.Parse(c.ToString()));
                }

                var result = 0;

                foreach (var i1 in numList)
                {
                    if (input % i1 == 0)
                    {
                        result++;
                    }
                }
                Console.WriteLine(result);
            }

        }
    }
}
