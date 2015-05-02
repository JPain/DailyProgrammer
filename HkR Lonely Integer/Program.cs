using System;
using System.Collections.Generic;
using System.Linq;

//Written by prmondal HkR <3

namespace HkR_Lonely_Integer
{
    class Solution
    {
        static int Lonelyinteger(int[] a)
        {
            var result = 0;
            var allTheNumbers = new int[100];

            foreach (var i in a)
            {
                allTheNumbers[i]++;
            }

            for (int i = 0; i < allTheNumbers.Length; i++)
            {
                if (allTheNumbers[i] == 1)
                {
                    result = i;
                }
            }

            return result;
        }
        static void Main(String[] args)
        {
            var aSize = Convert.ToInt32(Console.ReadLine());
            var a = new int[aSize];
            var move = Console.ReadLine();
            var moveSplit = move.Split(' ');
            for (var aI = 0; aI < moveSplit.Length; aI++)
            {
                var aItem = Convert.ToInt32(moveSplit[aI]);
                a[aI] = aItem;
            }

            var res = Lonelyinteger(a);
            Console.WriteLine(res);

        }
    }
}
