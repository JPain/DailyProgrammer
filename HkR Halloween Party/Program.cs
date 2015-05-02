using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HkR_Halloween_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            var numOfTestCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfTestCases; i++)
            {
                var numOfCuts = int.Parse(Console.ReadLine());
                Console.WriteLine((double)Math.Floor((double)numOfCuts / 2 * numOfCuts / 2));
            }
        }
    }
}
