using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Fig_8
{
    class Program
    {
        private int[] grades;
        public string CourseName { get; }
        public Program(string name, int[] gradesArray)
        {
            CourseName = name;
            grades = gradesArray;
        }
        public void DisplayMessage()
        {
            Console.WriteLine(
                $"Welcome to the grade book for \n{CourseName}!\n");
        }
        public void ProcessGrades()
        {
            OutputGrades();
            Console.WriteLine($"\nCalss average is {GetAverage():F}");

            Console.WriteLine($"Lowest grade is {GetMinimum()}");
            Console.WriteLine($"Highest grade is {GetMaximum()}\n");

            OutputBarChart();
        }

        public int GetMinimum()
        {
            var lowGrade = grades[0];
            foreach(var grade in grades)
            {
                if(grade < lowGrade)
                {
                    lowGrade = grade;
                }
            }
            return lowGrade;
        }

        public int GetMaximum()
        {
            var highGrade = grades[0];

            foreach(var grade in grades)
            {
                if(grade > highGrade)
                {
                    highGrade = grade;
                }
            }
            return highGrade;
        }
        public double GetAverage()
        {
            var total = 0.0;
            foreach(var grade in grades)
            {
                total += grade;
            }
            return total / grades.Length;
        }

        public void OutputBarChart()
        {
            Console.WriteLine("grade distribution");
            var frequency = new int[11];

            foreach(var grade in grades)
            {
                ++frequency[grade / 10];
            }
            for (var count =0; count < frequency.Length; ++count)
            {
                if(count == 10)
                {
                    Console.Write("  100: ");
                }
                else
                {
                    Console.Write($"{count * 10:D2}-{count * 10 + 9:D2}: ");
                }

                for(var stars = 0; stars < frequency[count]; ++stars)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public void OutputGrades()
        {
            Console.WriteLine("The grades are:\n");
            for(var student=0; student < grades.Length; ++student)
            {
                Console.WriteLine(
                    $"Student {student + 1,2}: {grades[student],3}");
            }
        }
        static void Main(string[] args)
        {
            int[] gradesArray = { 87, 68, 97, 100, 83, 78, 85, 91, 76, 87 };

            var myGradeBook = new Program(
                "CS101 Introduction to C# Programming", gradesArray);
            myGradeBook.DisplayMessage();
            myGradeBook.ProcessGrades();

        }
    }
}
