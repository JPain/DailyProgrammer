using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace HkR_Cut_The_Sticks
{
    class Solution
    {
        static void Main(String[] args) {
            var numOfStick = int.Parse(Console.ReadLine());
        
            var line2 = Console.ReadLine().Split(' ');
            var sticks = new List<int>();

            foreach(var i in line2){
                sticks.Add(int.Parse(i));
            }
        
            while(sticks.Count > 0)
            {
                Console.WriteLine(sticks.Count);

                var minLength = sticks.Min();

                for (int i = 0; i < sticks.Count; i++)
                {
                    sticks[i] = sticks[i] - minLength;
                }

                sticks.RemoveAll(x => x <= 0);
            }
        }
    }
}