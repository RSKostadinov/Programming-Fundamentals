using System;
using System.Collections.Generic;

/*
 Programming Fundamentals : John Smith
Programming Fundamentals : Linda Johnson
JS Core : Will Wilson
Java Advanced : Harrison White
end

Algorithms : Jay Moore
Programming Basics : Martin Taylor
Python Fundamentals : John Anderson
Python Fundamentals : Andrew Robinson
Algorithms : Bob Jackson
Python Fundamentals : Clark Lewis
end

 */
internal class Program
{
    static void Main()
    {
       Dictionary<string, Course> courses = new Dictionary<string, Course>();

        string input;
        while ((input= Console.ReadLine()) != "end")
        {
            string[] arguments = input.Split(" : ");

            string courseName = arguments[0];
            string studentName = arguments[1];

            if (!courses.ContainsKey(courseName))
            {
                Course course = new Course(courseName);
                courses.Add(courseName, course);
            }

            courses[courseName].StudentNames.Add(studentName);
        }

        foreach (var kvp in courses)
        {
            Console.WriteLine(kvp.Value);
        }
    }
}

class Course
{
    public Course(string name)
    {
        StudentNames = new List<string>();
        Name = name;
    }
    public string Name { get; set; }

    public List<string> StudentNames { get; set; }

    public override string ToString()
    {
        string result = $"{Name}: {StudentNames.Count}\n";

        for (int i = 0; i < StudentNames.Count; i++)
        {
            result += $"-- {StudentNames[i]}\n";
        }

        return result.Trim();
    }
}

