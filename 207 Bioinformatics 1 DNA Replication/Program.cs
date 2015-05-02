using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _207_Bioinformatics_1_DNA_Replication
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = null;

            while (String.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input DNA string:");
                input = Console.ReadLine();
            }

            var iArray = input.ToCharArray();

            for (int i = 0; i < iArray.Length; i++)
            {
                switch (iArray[i])
                {
                    case 'A':
                        iArray[i] = 'T';
                        break;
                    case 'T':
                        iArray[i] = 'A';
                        break;
                    case 'G':
                        iArray[i] = 'C';
                        break;
                    case 'C':
                        iArray[i] = 'G';
                        break;
                }
            }

            var result = new string(iArray);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
