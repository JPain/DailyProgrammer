using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HkR_Taum_and_B_day
{
    class Program
    {
        static void Main(string[] args)
        {
            var numOfTestCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfTestCases; i++)
            {
                var line1 = Console.ReadLine();
                var line2 = Console.ReadLine();

                long blackRequired = int.Parse(line1.Split(' ')[0]);
                long whiteRequired = int.Parse(line1.Split(' ')[1]);

                long blackCost = int.Parse(line2.Split(' ')[0]);
                long whiteCost = int.Parse(line2.Split(' ')[1]);
                long convertCost = int.Parse(line2.Split(' ')[2]);

                long runningTotal = 0;

                if (blackCost > whiteCost + convertCost) 
                    //Are Black Gifts more expensive than buying White Gifts and turning into Black?
                {
                    //Buy White Gifts and convert into Black
                    runningTotal += whiteCost * blackRequired;
                    runningTotal += convertCost * blackRequired;

                    runningTotal += whiteCost * whiteRequired;
                }
                else if (whiteCost > blackCost + convertCost) 
                    //Are White Gifts more expensive than buying Black Gifts and turning into White?
                {
                    //Buy Black Gifts and convert into White
                    runningTotal += blackCost * whiteRequired;
                    runningTotal += convertCost * whiteRequired;

                    runningTotal += blackCost * blackRequired;
                }
                else
                {
                    //Buy all original gifts
                    runningTotal += blackCost * blackRequired;
                    runningTotal += whiteCost * whiteRequired;
                }

                Console.WriteLine(runningTotal);
            }
        }
    }
}
