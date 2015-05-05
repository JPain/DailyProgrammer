using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HkR_Sherlock_and_GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            var numOfTestCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfTestCases; i++)
            {
                Console.ReadLine();
                var array = Console.ReadLine().Split().Select(int.Parse).ToList();


            }
        }
    }
}
