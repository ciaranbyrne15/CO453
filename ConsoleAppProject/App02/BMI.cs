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
        static void Main()
        {
            Console.WriteLine("BMI Calculator");

            Console.Write("Enter your preferred unit system(Metric or Imperial) > ");
            string unitSystem = Console.ReadLine();

            double weight = 0;
            double height = 0;

            if(unitSystem.ToLower() == "metric")
            {
                Console.Write("Enter your weight in kilograms > ");
                weight = double.Parse(Console.ReadLine());
                Console.Write("Enter your height in meters > ");
                height = double.Parse(Console.ReadLine());
            
            }
            else if(unitSystem.ToLower() == "imperial")
            {
                Console.Write("Enter your weight in pounds > ");
                weight = double.Parse(Console.ReadLine());
                Console.Write("Enter your height in inches > ");
                height = double.Parse(Console.ReadLine());
                if(height < 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
            }
            else
            {
                double feet = height/12.0;
                Console.WriteLine($"{height}inches is equal to {feet} feet");
            }

                //Converting weight from pounds to kilograms
                weight = weight*0.453592;

                //Converting height from inches to meters
                height = height*0.0254;
            }
            else
            {
                Console.WriteLine("Invalid unit system choice. Please try again.");
                return;
            }

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
