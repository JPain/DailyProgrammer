using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HkR_Alternating_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            var numOfTestCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfTestCases; i++)
            {
                var inputString = Console.ReadLine();
                var result = 0;

                for (int j = 0; j < inputString.Length - 1; j++)
                {
                    var currentChar = inputString[j];
                    var nextChar = inputString[j + 1];

                    if (currentChar == nextChar)
                    {
                        result++;
                    }
                }

                Console.WriteLine(result);
            }
        }
    }
}
