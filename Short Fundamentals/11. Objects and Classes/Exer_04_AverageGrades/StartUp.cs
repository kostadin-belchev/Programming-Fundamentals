namespace Exer_04_AverageGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Exer_04_AverageGrades.Classes;

    public class StartUp
    {
        public static void Main()
        {
            var studentsList = new List<Student>();
            int studentsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentsCount; i++)
            {
                string[] studentInfo = Console.ReadLine()
                    .Split(' ')
                    .ToArray();

                double[] grades = studentInfo
                    .Skip(1)
                    .Select(double.Parse)
                    .ToArray();

                var currentStudent = new Student
                {
                    Name = studentInfo[0],
                    Grades = grades
                };

                studentsList.Add(currentStudent);
            }

            var filteredStudents = studentsList
                .Where(avg => avg.AverageGrade >= 5.00)
                .OrderBy(n => n.Name)
                .ThenByDescending(g => g.AverageGrade)
                .ToList();

            foreach (var student in filteredStudents)
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade}");
            }
        }
    }
}
