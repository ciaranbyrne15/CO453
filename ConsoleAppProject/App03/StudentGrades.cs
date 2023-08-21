using System;
///using System.ComponentModel;
///using System.ComponentModel.DataAnnotations;
///using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// At the moment this class just tests the
    /// Grades enumeration names and descriptions
    /// </summary>
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

