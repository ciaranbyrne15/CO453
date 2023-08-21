using System;
using System.Diagnostics;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Ciaran Byrne version 0.1
    /// </author>
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
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
        
        public void ConvertDistance()
        {
            fromUnit = SelectUnit("Please select the from distance unit > ");
            toUnit = SelectUnit("Please select the to distace unit > ");


            OutputHeading($"Converting {fromUnit} to {toUnit}");

            fromDistance = InputDistance($"Please enter the number of {fromUnit} > ");
            CalculateFeet();
            
        }

        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);

            return ExecuteChoice(choice);
        }
        private static string ExecuteChoice(string choice)
        {
            ;

            if (choice.Equals("1"))
            {
                return FEET;
            }
            else if (choice == ("2"))
            {
                return METRES;
            }
            else if (choice.Equals("3"))
            {
                return MILES;
            }

            return null;





        }

        private string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {FEET}");
            Console.WriteLine($" 2. {METRES}");
            Console.WriteLine($" 3. {MILES}");
            Console.WriteLine();

            Console.WriteLine(prompt);
            string choice = Console.ReadLine();
            return choice;
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

        private void OutputDistance()
        {
            Console.WriteLine($" (fromDistance)  (fromUnit) +" +
                $" is (toDistance) (toUnit)!");
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

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }  

}
