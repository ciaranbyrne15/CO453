using System;
using System.Diagnostics;

namespace ConsoleAppProject.App01
{
    public class DistanceConverter
    { 
        public static double MilesToFeet(double miles)
        {
            return miles*5280;
        }

        public static double FeetToMiles(double feet)
        {
            return feet/5280;
        }

        public static double MilesToMetres(double miles)
        {
            return miles*1609.34;
        }

        public static void Main(string[]args)
        {   
            Console.WriteLine("Welcome to the Distance Converter");
            Console.WriteLine("Please enter the distance > ");
            double miles = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("1. Miles to Feet");
            Console.WriteLine("2.Feet to Miles");
            Console.WriteLine("3.Miles to Metres");

            int choice = Convert.ToInt32(Console.ReadLine());

            double result = 0;

            switch(choice)
            {
                case 1:
                    result = MilesToFeet(miles);
                    Console.WriteLine($"{miles}miles is equal to {result} feet.");
                    break;
                case 2:
                    result = FeetToMiles(miles);
                    Console.WriteLine($"{miles} feet is equal to {result} miles");
                    break;
                case 3:
                    result = MilesToMetres(miles);
                    Console.WriteLine($"{miles} miles is equal to {result} metres");
                    break;
                default: Console.WriteLine("Invalid choice. Please try again");
                break;
            }
        }
    }
}
