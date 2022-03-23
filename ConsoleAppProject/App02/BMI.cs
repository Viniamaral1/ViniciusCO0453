using System;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// This app provide 2 types is measure system for body mass
    /// </summary>
    /// <author>
    /// Vinicius Do Amaral version 0.1
    /// </author>
    public class BMI
    {
        public int selectUnit;

        public double bmi;

        public double height;

        public double weight;

        /// <summary>
        /// This fuctions is added to make the systenm works
        /// </summary>
        public void Run()
        {
            OutputHeading();
            SelectUnit();
            System();
            if (selectUnit == 1)
            {
                ImperialBMI();
            }
            else if (selectUnit == 2)
            {
                MetricBMI();
            }
            CalculateBMI();
            
        }

        

        /// <summary>
        /// That is the heading
        /// </summary>
        private void OutputHeading()
        {
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("            App02 BMI                       ");
            Console.WriteLine("            By Vinicius Do Amaral           ");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");
           
        }

        /// <summary>
        /// User can seletc between imperial and/or metric
        /// </summary>
        private void SelectUnit()
        {
            Console.Write(" Select 1 for Imperial system " +
                "or " +
                "2 for metric system >");
            string choiceU = Console.ReadLine();
            if (int.TryParse(choiceU, out selectUnit))
            {
                selectUnit = Convert.ToInt32(choiceU);
                if (!(selectUnit == 1 || selectUnit == 2))
                {
                    Console.WriteLine(" Please select between the options 1 for Imperial or 2 for Metric");
                    SelectUnit();
                }
            }
            else
            {
                Console.WriteLine(" The number select is incorrect ");
                SelectUnit();
            }
        }

        /// <summary>
        /// User inputs weight and height
        /// </summary>
        private void System()
        {
            string peak = "";
            string load = "";
            string inchtes = "";
            string pounds = "";

            if (selectUnit == 1)
            {
                inchtes = "inches";
                pounds = "pounds";
            }
            else
            {
                if (selectUnit  == 2)
                {
                    inchtes = "meters";
                    pounds = "kilograms";
                }
            }

            while (!double.TryParse(peak, out _))
            {
                Console.Write(" Please provide your height " + inchtes + " >");
                peak = Console.ReadLine();
            }
            height = Convert.ToDouble(peak);

            while (!double.TryParse(load, out _))
            {
                Console.Write(" Please provide your weight" + pounds + " >");
                load = Console.ReadLine();
            }
            weight = Convert.ToDouble(load);
        }

        /// <summary>
        /// caculates BMI using metric system
        /// </summary>
        public void MetricBMI()
        {
            bmi = weight / (height * height);
        }

        /// <summary>
        /// caculates BMI using imperial system
        /// </summary>
        public void ImperialBMI()
        {
            bmi = weight * 703 / (height * height);
        }

        /// <summary>
        /// Calculation with BMI
        /// </summary>
        private void CalculateBMI()
        {
            Console.WriteLine(" personal BMI is " + bmi);
            if (bmi < 18.5)
            {
                Console.WriteLine(" You are underweight");
            }
            else if (18.5 <= bmi && bmi < 25)
            {
                Console.WriteLine(" You are in the correct weight");
            }
            else if (25 <= bmi && bmi < 30)
            {
                Console.WriteLine(" You are overweight");
            }
            else if (30 <= bmi && bmi < 35)
            {
                Console.WriteLine(" You are above the weight class 1");
            }
            else if (35 <= bmi && bmi < 40)
            {
                Console.WriteLine(" You are above the weight class 2");
            }
            else if (bmi >= 40)
            {
                Console.WriteLine(" You are above the weight 3");
            }

            
        }

        
        
    }

}   


