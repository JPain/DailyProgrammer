using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HkR_Maximizing_XOR
{
    class Program
    {
        static void Main(string[] args)
        {

            var numFrom = int.Parse(Console.ReadLine());
            var numTo = int.Parse(Console.ReadLine());

            var xorResults = new List<int>();

            for (var num1 = numFrom; num1 <= numTo; num1++)
            {

                for (var num2 = numFrom; num2 <= numTo; num2++)
                {
                    xorResults.Add(num1 ^ num2);
                }

            }
            
            var result = xorResults.Max();

            Console.WriteLine(result.ToString());
        
        }
    }
}
