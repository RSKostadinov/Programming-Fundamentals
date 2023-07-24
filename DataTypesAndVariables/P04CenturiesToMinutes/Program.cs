using System;

namespace P04CenturiesToMinutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            double year = 365.24217f;
            int years = centuries * 100;

            double days = Math.Floor(years * year);

            double hours = Math.Floor(days * 24);
            double minutes =Math.Floor(hours * 60);

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
