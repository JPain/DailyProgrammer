using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _208_Culling_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gimmie your input:");
            var input = Console.ReadLine();
            if (String.IsNullOrEmpty(input))
            {
                return;
            }

            var splitInput = input.Split(' ');

            var collection = new Collection<int>();

            foreach (var num in splitInput.Select(s => Convert.ToInt32(s)).Where(num => !collection.Contains(num)))
            {
                collection.Add(num);
            }

            foreach (var i in collection)
            {
                Console.Write(i + " ");
            }

            Console.ReadKey();
        }
    }
}
