using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HkR_Ice_Cream_Parlor
{
    class Program
    {
        static void Main(string[] args)
        {
            var numOfTestCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfTestCases; i++)
            {
                var money = int.Parse(Console.ReadLine());
                Console.ReadLine();
                var priceOfFlavours = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                var result = Looptastic(priceOfFlavours, money);
                Console.WriteLine(result);
            }
            Console.ReadKey();
        }

        static string Looptastic(List<int> priceOfFlavours, int money)
        {
            for (int j = 0; j < priceOfFlavours.Count; j++)
            {
                var firstPrice = priceOfFlavours[j];
                for (int k = j + 1; k < priceOfFlavours.Count; k++)
                {
                    var secondPrice = priceOfFlavours[k];

                    if (firstPrice + secondPrice == money)
                    {
                        return (j + 1) + " " + (k + 1);
                    }
                }
            }
            return "";
        } 
    }
}
