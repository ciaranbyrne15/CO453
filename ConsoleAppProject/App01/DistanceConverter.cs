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
        public const int FEET_IN_MILES = 5280;
        private double miles;
        private double feet;

        public void MilesToFeet()
        {
            OutputHeading("Converting Miles to Feet");

            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        public void FeetToMiles()
        {
            OutputHeading("Converting Feet to Miles");

            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        public void MilesToMetres()
        {
            OutputHeading("Converting Miles to Metres");

            InputMiles();
            CalculateFeet();
            OutputFeet();
        }


        public void Run()
        {
            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        private void OutputHeading(String prompt)
        {
            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("                 Distance Converter ");
            Console.WriteLine("                   by Ciaran Byrne                                ");
            Console.WriteLine(" =================================================");
            Console.WriteLine(prompt);
            Console.WriteLine();
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

        private void CalculateMiles()
        {
            miles = feet / FEET_IN_MILES
        }

        private void OutputMiles()
        {
            Console.WriteLine(feet + "feet is" + miles + "miles")
        }

        private void CalculateMetres()
        { 
           metres = miles * 1609.344 
        }

        private void OutputMetres()
        {
            Console.WriteLine(miles + "miles is " + metres + "metres")
        }            
    }  

}
