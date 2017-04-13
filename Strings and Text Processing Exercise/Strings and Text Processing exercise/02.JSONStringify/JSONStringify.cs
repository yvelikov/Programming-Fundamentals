using System;
using System.Collections.Generic;
using System.Text;

namespace _02.JSONStringify
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<int> Grades { get; set; }
    }
    public class JSONStringify
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var studentsList = new List<Student>();

            while (inputLine != "stringify")
            {
                var inputParams = inputLine.Split(new[] { ' ', ',', ':', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var currenStudent = new Student();
                currenStudent.Name = inputParams[0];
                currenStudent.Age = int.Parse(inputParams[1]);
                currenStudent.Grades = new List<int>();

                for (int i = 2; i < inputParams.Length; i++)
                {
                    currenStudent.Grades.Add(int.Parse(inputParams[i]));
                }

                studentsList.Add(currenStudent);

                inputLine = Console.ReadLine();
            }

            var result = new StringBuilder();
            result.Append('[');
            var count = 0;
            foreach (var student in studentsList)
            {
                result.Append('{');
                result.Append($"name:\"{student.Name}\",age:{student.Age},grades:[{string.Join(", ", student.Grades)}]");
                count++;
                if (count == studentsList.Count)
                {
                    result.Append('}');
                }
                else result.Append("},");
                
            }
            result.Append(']');

            Console.Write(result.ToString());
        }
    }
}
