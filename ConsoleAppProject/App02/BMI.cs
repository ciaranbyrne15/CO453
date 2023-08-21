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

            string weightStatus = "";

            if(bmi < 18.5)
            {
                weightStatus = "Underweight";
            }
            else if(bmi < 24.9)
            {
                weightStatus = "Normal Weight";
            }
            else if(bmi < 29.9)
            {
                weightStatus = "Overweight";
            }
            else if(bmi < 34.9)
            {
                weightStatus = "Obese Class 1";
            }
            else if(bmi < 39.9)
            {
                weightStatus = "Obese Class 2";
            }
            else
            {
                weightStatus = "Obese Class 3";
            }

            Console.WriteLine($"Your weight status according to WHO > {weightStatus}");
        }
    }
}
