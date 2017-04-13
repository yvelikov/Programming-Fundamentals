namespace _03.JSONParse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<int> Grades { get; set; }
    }

    public class JSONParse
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var inputParams = inputLine.Split(new[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries);

            var studentInfo = new List<string>();

            foreach (var param in inputParams)
            {
                if (param != "[" && param != "]" && param != ",")
                    studentInfo.Add(param);
            }

            var studentsList = new List<Student>();

            for (int i = 0; i < studentInfo.Count; i++)
            {
                var currentStudentParams = studentInfo[i].Split(new[] { ':', ',', '[', ']', ' ', '"' }, StringSplitOptions.RemoveEmptyEntries);
                var currentStudent = new Student
                {
                    Name = currentStudentParams[1],
                    Age = int.Parse(currentStudentParams[3]),
                    Grades = new List<int>()
                };

                for (int j = 5; j < currentStudentParams.Length; j++)
                {
                    currentStudent.Grades.Add(int.Parse(currentStudentParams[j]));
                }

                studentsList.Add(currentStudent);
                
            }

            foreach (var student in studentsList)
            {
                if (student.Grades.Count > 0)
                {
                    Console.WriteLine($"{student.Name} : {student.Age} -> {string.Join(", ", student.Grades)}");
                }
                else
                {
                    Console.WriteLine($"{student.Name} : {student.Age} -> None");
                }
                
            }
        }
    }
}
