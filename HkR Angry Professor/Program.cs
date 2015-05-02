using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HkR_Angry_Professor
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

                var minRequired = int.Parse(line1.Split(' ')[1]);
                var students = new List<int>();

                foreach (var s in line2.Split(' '))
                {
                    students.Add(int.Parse(s));
                }

                if (students.FindAll(x => x <= 0).Count >= minRequired)
                {
                    Console.WriteLine("NO");
                }
                else
                {
                    Console.WriteLine("YES");
                }

            }
            Console.ReadKey();
        }
    }
}
