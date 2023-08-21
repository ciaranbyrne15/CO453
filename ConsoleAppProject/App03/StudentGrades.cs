using System;
using System.ComponentModel;
using System.ComponentModel.Design;
///using System.ComponentModel;
///using System.ComponentModel.DataAnnotations;
///using ConsoleAppProject.Helpers;

/// This app


namespace ConsoleAppProject.App03
{
    public class StudentGrades
    {
        static void Main()
        {
            int[]marks = new int[10];
            char[]grades = new char[10];
            int sum = 0;
            int minMark = int.MaxValue;
            int maxMark = int.MinValue;

            for(int i = 0; i < 10; i++)
            { 
                Console.Write($"Enter mark for student{i + 1} > ");
                marks[i] = Convert.ToInt32(Console.ReadLine());

                if(marks[i]>= 0 && marks[i]<= 39)
                grades[i] = 'F';
                else if(marks[i]>= 40 && marks[i]<= 49)
                grades[i] = 'D';
                else if(marks[i]>= 50 && marks[i]<= 59)
                grades[i] = 'C';
                else if(marks[i]>= 60 && marks[i]<= 69)
                grades[i] = 'B';
                else if(marks[i]>= 70 && marks[i]<= 100)
                grades[i] = 'A';
                
                sum += marks[i];
                minMark = Math.Min(minMark, marks[i]);
                maxMark = Math.Max(maxMark, marks[i]);
                
            }
            Console.WriteLine("Enter the total number of students > ");
            int totalStudents = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the total number of students with Grade A > ");
            int gradeA = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the total number of students with Grade B > ");
            int gradeB = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the total number of students with Grade C > ");
            int gradeC = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the total number of students with Grade D > ");
            int gradeD = int.Parse(Console.ReadLine());

            double percentageA = (double)gradeA/totalStudents*100;
            double percentageB = (double)gradeB/totalStudents*100;
            double percentageC = (double)gradeC/totalStudents*100;
            double percentageD = (double)gradeD/totalStudents*100;

            Console.WriteLine("Grade A: " + percentageA + "%");
            Console.WriteLine("Grade B: " + percentageB + "%");
            Console.WriteLine("Grade C: " + percentageC + "%");
            Console.WriteLine("Grade D: " + percentageD + "%");

            double meanMark = (double)sum/10;

            Console.WriteLine("\nGrades > ");

            for(int i = 0; i < 10; i++)

            {
                Console.WriteLine($"Student{i+1}:{grades[i]}");
            }

            Console.WriteLine($"\nMean Mark > {meanMark}");
            Console.WriteLine($"Minimum Mark > {minMark}");
            Console.WriteLine($"Maximum Mark > {maxMark}");
            }
        }
    }


    
    

