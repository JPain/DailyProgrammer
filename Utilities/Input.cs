using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    static public class Input
    {
        static public int[] GetIntInput(string inputMessage, int numOfInput)
        {
            int[] result = null;

            while (result == null)
            {
                Console.WriteLine(inputMessage);

                var input = Console.ReadLine();
                if (String.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Please enter an input.");
                    continue;
                }

                var splitInput = input.Split(' ');
                if (splitInput.Length != numOfInput)
                {
                    Console.WriteLine("Num of input requred: " + numOfInput + ". Num entered: " + splitInput.Length + ". Please try again.");
                    continue;
                }

                var inputConvert = new List<int>();

                var foreachResult = true;
                foreach (var s in splitInput)
                {
                    int parseOutput;
                    if (!int.TryParse(s, out parseOutput))
                    {
                        Console.WriteLine("Input wasn't a number: " + s + ". Please try again.");
                        foreachResult = false;
                        break;
                    }
                    inputConvert.Add(parseOutput);
                }
                if (foreachResult)
                {
                    result = inputConvert.ToArray();
                }
            }
            return result;
        }
    }
}
