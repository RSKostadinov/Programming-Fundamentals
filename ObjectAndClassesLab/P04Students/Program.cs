using System;
using System.Collections.Generic;

internal class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();

        string command;
        while ((command = Console.ReadLine()) != "end")
        {
            string[] arguments = command.Split();
            string firstName = arguments[0];
            string lastName = arguments[1];
            int age = int.Parse(arguments[2]);
            string city = arguments[3];


            Student student = new Student()
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age,
                City = city
            };
            students.Add(student);
        }

        string filterCity = Console.ReadLine();

        foreach (Student student in students)
        {
            if (student.City == filterCity)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }
}

class Student
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int Age { get; set; }

    public string City { get; set; }


}

