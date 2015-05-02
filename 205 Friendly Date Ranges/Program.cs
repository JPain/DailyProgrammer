using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _205_Friendly_Date_Ranges
{

    //July 1st - 4th
    //December 1st - February 3rd
    //December 1st, 2015 - February 3rd, 2017
    //March 1st - May 5th, 2016
    //January 1st, 2017
    //September 5th, 2022 - September 4th, 2023

    public class Program
    {
        static void Main(string[] args)
        {
            var inputDates = GetInput().Split(' ');
            var dateFrom = ReturnDateTime(inputDates[0]);
            var dateTo = ReturnDateTime(inputDates[1]);

            var result = ReturnHumanFriendlyDates(dateFrom, dateTo);

            Console.WriteLine(result);
            Console.ReadKey();
        }

        static string ReturnHumanFriendlyDates(DateTime dateFrom, DateTime dateTo)
        {
            var result = new StringBuilder();

            result.Append(dateFrom.ToString("MMMM") + " " + dateFrom.Day + " ");

            //Evaluate if fromYear needs to be shown
            if (dateFrom.Year != 2015)
            {
                result.Append(dateFrom.Year);
            }

            if (dateFrom.Equals(dateTo))
            {
                return result.ToString();
            }

            result.Append(" -");

            if (dateFrom.Month == dateTo.Month && dateFrom.Year == dateTo.Year)
            {
                result.Append(" " + dateTo.Day);
                return result.ToString();
            }

            result.Append(" " + dateTo.ToString("MMMM") + " " + dateTo.Day);

            if ((dateFrom.DayOfYear + dateTo.DayOfYear) > 364 || dateFrom.Year != 2015)
            {
                result.Append(" " + dateTo.Year);
            }
            return result.ToString();
        }

        static string GetDaySuffix(int day)
        {
            switch (day)
            {
                case 1:
                case 21:
                case 31:
                    return "st";
                case 2:
                case 22:
                    return "nd";
                case 3:
                case 23:
                    return "rd";
                default:
                    return "th";
            }
        }

        static DateTime ReturnDateTime(string inputstring)
        {
            var splitInput = inputstring.Split('-');

            var year = int.Parse(splitInput[0]);
            var month = int.Parse(splitInput[1]);
            var day = int.Parse(splitInput[2]);

            return new DateTime(year, month, day);
        }

        static string GetInput()
        {
            var result = "";
            while (String.IsNullOrEmpty(result))
            {
                while (String.IsNullOrEmpty(result))
                {
                    Console.WriteLine("Input:");
                    Console.WriteLine("Example: YYYY-MM-DD YYYY-MM-DD");
                    result = Console.ReadLine();
                }
                if (result.Length != "YYYY-MM-DD YYYY-MM-DD".Length) result = "";
            }

            return result;
        }
    }
}
