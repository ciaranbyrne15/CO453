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
        public const double METRES_IN_MILES = 1609.34;
        public const double FEET_IN_METRES = 3.28084;

        public const string FEET = "Feet";
        public const string METRES = "Metres";
        public const string MILES = "Miles";

        private double fromDistance;
        private double toDistance;

        private string fromUnit;
        private string toUnit;

        public DistanceConverter()
        {
            fromUnit = MILES;
            toUnit = FEET;
        }
        
        public void MilesToFeet()
        {
            OutputHeading($"Converting {fromUnit} to {toUnit}");

            fromDistance = InputDistance($"Please enter the number of {fromUnit} > ");
            CalculateFeet();
            OutputDistance(fromDistance, fromUnit, toDistance, toUnit);
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
        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return = Convert.ToDouble(value);

        }

        private void InputMiles()
        {
            Console.Write("Please enter the number of miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);

        }

        private void InputMetres()
        {
            Console.Write("Please enter the number of metres > ");
            string value = Console.ReadLine();
            metres = Convert.ToDouble(value);

        }

        private void InputFeet()
        {
            Console.Write("Please enter the number of feet > ");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);

        }

        private void CalculateFeet()
        {
            feet = miles * 5280;
        }

        private void OutputDistance(
            double fromDistance, string fromUnit,
            double toDistance, string toUnit)
        {
            Console.WriteLine($" (fromDistance)  (fromUnit) +" +
                $" is (toDistance) (toUnit)!")
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
