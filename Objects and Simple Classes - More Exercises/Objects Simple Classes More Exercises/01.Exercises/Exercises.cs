namespace _01.Exercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Exercise
    {
        public string Topic { get; set; }
        public string CourseName { get; set; }
        public string JudgeLink { get; set; }
        public List<string> Problem { get; set; }
    }

    public class Exercises
    {
        public static void Main()
        {
            var entry = Console.ReadLine();

            var exercises = new List<Exercise>();

            while (entry != "go go go")
            {
                var currentExcercise = ReadExcercises(entry);
                exercises.Add(currentExcercise);

                entry = Console.ReadLine();
            }

            foreach (var exercise in exercises)
            {
                Console.WriteLine($"Exercises: {exercise.Topic}");
                Console.WriteLine($"Problems for exercises and homework for the \"{exercise.CourseName}\" course @ SoftUni.");
                Console.WriteLine($"Check your solutions here: { exercise.JudgeLink}");
                var count = 1;
                foreach (var problem in exercise.Problem)
                {
                    Console.WriteLine($"{count}. {problem}");
                    count++;
                }
            }
        }

        public static Exercise ReadExcercises(string entry)
        {
            var exercisesParams = entry.Split(new[] {'-','>',' ',','}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var topic = exercisesParams[0];
            var courseName = exercisesParams[1];
            var judgeLink = exercisesParams[2];
            

            var currentExercise =  new Exercise
            {
                Topic = topic,
                CourseName = courseName,
                JudgeLink = judgeLink,
                Problem = new List<string>()
            } ;

            for (int i = 3; i < exercisesParams.Length; i++)
            {
                currentExercise.Problem.Add(exercisesParams[i]);
            }

            return currentExercise;
        }
    }
}
