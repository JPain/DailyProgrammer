using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HkR_Chocolate_Feast
{
    class Program
    {
        static void Main(string[] args)
        {
            int m;
            m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                var line1 = Console.ReadLine().Split(' ');

                var bobsMoney = int.Parse(line1[0]);
                var cost = int.Parse(line1[1]);
                var freebie = int.Parse(line1[2]);
                var bars = 0;

                while (bobsMoney >= cost)
                {
                    bobsMoney -= cost;
                    bars++;
                    if (bars % freebie == 0)
                    {
                        bars++;
                    }
                }

                Console.WriteLine(bars);
            }
        }
    }
}
