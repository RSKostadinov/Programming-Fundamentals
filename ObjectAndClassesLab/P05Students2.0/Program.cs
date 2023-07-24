﻿using System;
using System.Collections.Generic;

internal class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();

        string input;
        while ((input = Console.ReadLine()) != "end")
        {
            string[] arguments = input.Split();

            string firstName = arguments[0];
            string lastName = arguments[1];
            int age = int.Parse(arguments[2]);
            string city = arguments[3];


            if (IsStudentExisting(students, firstName, lastName))
            {
                Student student = GetStudent(students, firstName, lastName);

                student.FirstName = firstName;
                student.LastName = lastName;
                student.Age = age;
                student.City = city;
            }
            else
            {
                Student student = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    City = city,
                };

                students.Add(student);
            }
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
    static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
    {
        foreach (Student student in students)
        {
            if (student.FirstName == firstName && student.LastName == lastName)
            {
                return true;
            }
        }

        return false;
    }
    static Student GetStudent(List<Student> students, string firstName, string lastName)
    {
        Student existingStudent = null;

        foreach (Student student in students)
        {
            if (student.FirstName == firstName && student.LastName == lastName)
            {
                existingStudent = student;
            }
        }

        return existingStudent;
    }
}
class Student
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int Age { get; set; }

    public string City { get; set; }

}
