using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Ciaran Byrne version 0.1
    /// </author>
    public class DistanceConverter
    {
        private double miles;
        private double feet;

        public void Run()
        {
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }
        private void InputMiles()
        {
            Console.Write("Please enter the number of miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);

        }

        private void CalculateFeet()
        {
            feet = miles * 5280;
        }

        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + "feet");
        }
    }
}
