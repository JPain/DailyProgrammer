using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HkR_Manasa_and_Stones
{
    class Program
    {

        static public int A { get; set; }
        static public int B { get; set; }
        static public int NumOfStones { get; set; }
        static public List<int> Result { get; set; }
        static public int Count { get; set; }

        static void Main(string[] args)
        {
            var numOfTestCases = int.Parse(Console.ReadLine());


            for (int i = 0; i < numOfTestCases; i++)
            {
                Result = new List<int>();
                Count = 0;
                NumOfStones = int.Parse(Console.ReadLine());
                A = int.Parse(Console.ReadLine());
                B = int.Parse(Console.ReadLine());
                Process(0);

                Result.Sort();

                foreach (var i1 in Result)
                {
                    Console.Write(i1 + " ");
                }
                Console.Write("\n");
            }
        }

        static void Process(int runningNumber)
        {
            if (Count == NumOfStones)
            {
                if (!Result.Contains(runningNumber))
                {
                 Result.Add(runningNumber);
                }
            }
            else
            {
                Count++;
                Process(runningNumber + A);
                Process(runningNumber + B);
            }
            
        }
    }
}
