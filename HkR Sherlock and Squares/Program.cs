using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HkR_Sherlock_and_Squares
{
    class Program
    {
        static void Main(string[] args)
        {
            var numOfTestCases = int.Parse(Console.ReadLine());

            for (int j = 0; j < numOfTestCases; j++)
            {
                var line1 = Console.ReadLine().Split(' ');
                double min = double.Parse(line1[0]);
                double max = double.Parse(line1[1]);
                double count = 0;
                double startingNumber = Math.Round(Math.Sqrt(min));

                for (double i = startingNumber; i <= Math.Sqrt(max); i++)
                {
                    var x = i*i;
                    if (x >= min && x <= max)
                    {
                        count++;
                    }
                    if (x > max)
                    {
                        break;
                    }
                }
                Console.WriteLine(count);
            }
        }
    }
}
