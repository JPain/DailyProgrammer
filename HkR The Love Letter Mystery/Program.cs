using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HkR_The_Love_Letter_Mystery
{
    class Program
    {
        static void Main(string[] args)
        {
            var numTestCases = int.Parse(Console.ReadLine());

            var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower().ToCharArray();

            for (var i = 0; i < numTestCases; i++)
            {
                var input = Console.ReadLine();
                var splitInput = input.ToCharArray();

                var loopLenth = (int)Math.Floor((double) (splitInput.Length/2));

                var result = 0;

                for (int j = 0; j < loopLenth; j++)
                {
                    var letter1Val = Array.IndexOf(alphabet, splitInput[j]);
                    var letter2Val = Array.IndexOf(alphabet, splitInput[splitInput.Length - 1 - j]);

                    if (letter1Val > letter2Val)
                    {
                        result += letter1Val - letter2Val;
                    }
                    if (letter1Val < letter2Val)
                    {
                        result += letter2Val - letter1Val;
                    }
                }

                Console.WriteLine(result.ToString());
            }
        }
    }
}
