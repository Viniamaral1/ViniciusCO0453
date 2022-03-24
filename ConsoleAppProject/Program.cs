using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.Helpers;
using System.Linq;

using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Vinicius Do Amaral 08/03/2022
    /// </summary>
    public static class Program
    {
        private static int cantryagain;

        public static void Main(string[] args)
        {

          

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    BNU CO453 Applications Programming 2021-2022! ");
            Console.WriteLine("        by Derek                                  ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();


            Console.WriteLine(" Pleaes informe the App you`d like to use > ");
            Console.WriteLine("        Distance converter (1)      ");
            Console.WriteLine("          BMI calculator   (2)      ");
            Console.WriteLine("          Student Grades   (3)      ");

            string choice = Console.ReadLine();
            if (Double.TryParse(choice, out _))
            {

               


                
                

                double option = Convert.ToDouble(choice);
                if (option == 1)
                {
                    DistanceConverter App01 = new DistanceConverter();
                    App01.Run();
                }
                else if (option == 2)
                {
                    BMI app02 = new BMI();
                    app02.Run();
                }
                else if (option == 3)
                {
                    StudentGrades App03 = new StudentGrades();
                    App03.Run();
                }
                else
                {
                    Console.WriteLine("Incorrect option, please try again");
                    Tryagain();
                }
            }
        }

        private static void Tryagain()
        {

            Myfunction();
            cantryagain = 1;

        }

        private static void Myfunction()
        {


        }
    }
}

