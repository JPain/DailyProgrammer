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

                var b = int.Parse(line1.Split(' ')[0]);
                var w = int.Parse(line1.Split(' ')[1]);

                var x = int.Parse(line2.Split(' ')[0]);
                var y = int.Parse(line2.Split(' ')[1]);
                var z = int.Parse(line2.Split(' ')[2]);

                long totalCost = 0;

                if (x > y + z) //Are Black Gifts more expensive than buying White Gifts and turning into Black?
                {
                    //Buy White Gifts and convert into Black
                    totalCost += y * b;
                    totalCost += z * b;

                    totalCost += y * w;
                }
                else if (y > x + z) //Are White Gifts more expensive than buying Black Gifts and turning into White?
                {
                    //Buy Black Gifts and convert into White
                    totalCost += x * w;
                    totalCost += z * w;

                    totalCost += x * b;
                }
                else
                {
                    //Buy all original gifts
                    totalCost += x * b;
                    totalCost += y * w;
                }

                Console.WriteLine(totalCost);
            }
        }
    }
}
