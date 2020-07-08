using System;
using System.Linq;
using System.Collections.Generic;

namespace P02AverageStudentGrades
{
    class Program
    {
        static void Main()
        {
            int gradesCount = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> dictNameGrade = new Dictionary<string, List<double>>();

            for (int i = 0; i < gradesCount; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                double grade = double.Parse(input[1]);

                if (!dictNameGrade.ContainsKey(name))
                {
                    dictNameGrade.Add(name, new List<double>());
                }

                dictNameGrade[name].Add(grade);
            }

            foreach (var item in dictNameGrade)
            {
                Console.WriteLine($"{item.Key} -> {string.Join(" ", item.Value.Select(x =>x.ToString("F2")))} (avg: {item.Value.Average():f2})");
            }
        }
    }
}
