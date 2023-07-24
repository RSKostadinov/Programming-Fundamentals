﻿using System;

namespace P03Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)peopleCount / elevatorCapacity);
            Console.WriteLine(courses);
            
        }
    }
}
