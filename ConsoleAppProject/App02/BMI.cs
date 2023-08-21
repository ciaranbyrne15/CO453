using System;
namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>
    public class BMI
    {
        static void BMICalculator()
        {
            Console.WriteLine("BMI Calculator");

            Console.Write("Enter your weight in kilograms > ");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("Enter your height in meters > ");
            double height = double.Parse(Console.ReadLine());

            double bmi = weight/(height*height);

            Console.WriteLine($"Your BMI is: {bmi}");
        }
    }
}
