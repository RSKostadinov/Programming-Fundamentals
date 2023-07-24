using System;

namespace P01DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] dayOfWeek = new string[7];
            dayOfWeek[0] = "Monday";
            dayOfWeek[1] = "Tuesday";
            dayOfWeek[2] = "Wednesday";
            dayOfWeek[3] = "Thursday";
            dayOfWeek[4] = "Friday";
            dayOfWeek[5] = "Saturday";
            dayOfWeek[6] = "Sunday";

            switch (n)
            {
                case 1:
                    Console.WriteLine(dayOfWeek[0]);
                    break;
                    case 2:
                    Console.WriteLine(dayOfWeek[1]);
                    break;
                    case 3:
                    Console.WriteLine(dayOfWeek[2]);
                    break;
                    case 4:
                    Console.WriteLine(dayOfWeek[3]);
                    break; 
                    case 5:
                    Console.WriteLine(dayOfWeek[4]);
                    break;
                        case 6:
                    Console.WriteLine(dayOfWeek[5]);
                    break;
                    case 7:
                    Console.WriteLine(dayOfWeek[6]);
                    break;
                default:
                    Console.WriteLine("Invalid day!");
                    break;
            }
        }
    }
}
