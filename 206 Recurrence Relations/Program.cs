using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _206_Recurrence_Relations
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Expression:");
            var inputExpression = Console.ReadLine();

            Console.WriteLine("Starting number:");
            var inputStartNumber = Console.ReadLine();

            Console.WriteLine("Number of reptitions:");
            var inputReps = Console.ReadLine();

            DataTable dt = new DataTable();
            var v = dt.Compute("2 + 2", "");

        }
    }
}
