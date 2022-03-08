using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This app was built as a converter for unite of measurement system
    /// </summary>
    /// <author>
    /// Vinicius Do amaral
    /// </author>
    public class DistanceConverter
     
    {
        private double miles;


        private double feet;

        public bool Value { get; private set; }

        public void Run()
        {
            Outputheading();

            InputMiles();
            CalculateFeet();
            OutputFeet();
            OutputMiles();
            CalculateMiles();

        
        }

        private void OutputMiles()
        {
            Console.WriteLine();
            Console.WriteLine("  " + feet + " feet is " + miles + " miles ");
            Console.WriteLine();
        }

        private void OutputFeet()
        {
            Console.WriteLine();
            Console.WriteLine("  "  +  miles + " miles is "  + feet + " feet ");
            Console.WriteLine();
        }

        private void CalculateFeet()
        {
            feet = miles * 5280;
        }

        private void CalculateMiles()
        {
            miles = feet * 0.00018939;


        }

        /// <summary>
        /// Output a message to the user to enter the miles
        /// and read it in as a string and convert it to a double
        /// </summary>

        private void InputMiles()
        {
            Console.Write(" Enter the distance in miles >  ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }


        /// <summary>
        /// Output a message to the user to enter the miles
        /// and read it in as a string and convert it to a double
        /// </summary>

        private void Inputfeet()
        {
            Console.Write(" Enter the distance in feet >  ");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);

        }
        private void Outputheading()
        {
            Console.WriteLine("    ===========================  ");
            Console.WriteLine("     App01; Distance converter   ");
            Console.WriteLine("       By Vinicius Do Amaral     ");
            Console.WriteLine("    ===========================  ");


        }


    }
}
