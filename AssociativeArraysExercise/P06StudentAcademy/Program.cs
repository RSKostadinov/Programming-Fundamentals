using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main()
    {
        Dictionary<string, Student> students = new Dictionary<string, Student>();

        int studentsCount = int.Parse(Console.ReadLine());

        string studentName;
        decimal grade;

        for (int i = 0; i < studentsCount; i++)
        {
            studentName = Console.ReadLine();
            grade = decimal.Parse(Console.ReadLine());

            if (!students.ContainsKey(studentName))
            {
                students.Add(studentName, new Student(studentName));
            }

            students[studentName].Grades.Add(grade);
        }

        IEnumerable<KeyValuePair<string, Student>> filteredStudents = students.Where(g => g.Value.Grades.Average() >= 4.50m);

        foreach (var kvp in filteredStudents)
        {
            Console.WriteLine($"{kvp.Value}");
        }
    }
}
class Student
{
    public Student(string name)
    {
        Grades = new List<decimal>();
        Name = name;
    }

    public string Name { get; set; }

    public List<decimal> Grades { get; set; }

    public override string ToString()
    {
        return $"{Name} -> {Grades.Average():F2}";
    }
}

