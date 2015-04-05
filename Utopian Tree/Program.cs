using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utopian_Tree
{
    //https://www.hackerrank.com/challenges/utopian-tree

    class Solution
    {
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(GetHeight(input));
            }
        }

        static int GetHeight(int cycles)
        {
            var result = 1;
            if (cycles <= 0) return result;

            for (int i = 0; i < cycles; i++)
            {
                if (i % 2 != 0)
                {
                    result += 1;
                }
                else
                {
                    result = result * 2;
                }
            }
            return result;
        }
    }
}
