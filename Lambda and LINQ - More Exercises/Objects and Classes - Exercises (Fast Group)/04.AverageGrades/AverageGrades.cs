namespace _04.AverageGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade { get; set; }
    }

    public class AverageGrades
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var studentsAvgGrades = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                var student = ReadStudents();

                studentsAvgGrades.Add(student);
            }

            var studentsToPrint = studentsAvgGrades
                .Where(x => x.AverageGrade >= 5.00d)
                .OrderBy(x => x.Name)
                .ThenByDescending(x => x.AverageGrade)
                .ToList();

            foreach (var student in studentsToPrint)
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:F2}");
            }
        }

        public static Student ReadStudents()
        {
            var studentParams = Console.ReadLine().Split(' ');
            var gradesList = new List<double>();
            var name = studentParams[0];

            for (int i = 1; i < studentParams.Length; i++)
            {
                gradesList.Add(double.Parse(studentParams[i]));
            }

            var averageGrade = gradesList.Average();

            return new Student
            {
                Name = name,
                Grades = gradesList,
                AverageGrade = averageGrade
            };
        }
    }
}
