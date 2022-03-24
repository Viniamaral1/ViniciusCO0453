using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// This app shows  the student grades
    /// </summary>
    /// <author>
    /// Vinicius Do Amaral version 1.0
    /// </author>
    public class StudentGrades
    {
        public const int Number_of_Students = 10;
        private readonly int percentage;

        public string[] Students { get; set; }
        public int[] Marks { get; set; }
        public Grades[] Grades { get; set; }
        public int[] Gradeprofile { get; set; }

        public int Total { get; set; }
        public double Mean { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        /// <summary>
        /// assign stuff to stuff
        /// </summary>
        public StudentGrades()
        {
            Students = new string[Number_of_Students] { "Jon", "Marly", "Vini", "Jack", "Nile", "Tinno"
                , "Joseph", "Alex", "Sebastian", "Josh" };
            Marks = new int[Number_of_Students] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            Grades = new Grades[Number_of_Students] { App03.Grades.F, App03.Grades.F, App03.Grades.F, App03.Grades.D, App03.Grades.C, App03.Grades.B, App03.Grades.A, App03.Grades.A, App03.Grades.A, App03.Grades.A };
            Gradeprofile = new int[5];
        }

        /// <summary>
        /// System to Run the heading and menu
        /// </summary>
        public void Run()
        {
            Outputheading();
            


        }

        

        /// <summary>
        /// I have added the menu and Heading together
        /// </summary>
        private void Outputheading()
        {
            Console.WriteLine("    ===========================  ");
            Console.WriteLine("     App03: Students Grade  ");
            Console.WriteLine("       By Vinicius Do Amaral     ");
            Console.WriteLine("    ===========================  ");
            Console.WriteLine("    Select the desirable option >");
            Console.WriteLine("     1 Input Marks      ");
            Console.WriteLine("     2 Output Marks             ");
            Console.WriteLine("     3 Output Staks              ");
            Console.WriteLine("     4 Output Grade Profile      ");
            Console.WriteLine("     5 Exit              ");
            Console.WriteLine("     =========================== ");


            string choice = Console.ReadLine();
            if (Double.TryParse(choice, out _))

            {
                double option = Convert.ToDouble(choice);
                if (option == 1)
                {
                    InputMarks();
                    
                }
                else if (option == 2)
                {
                    OutputMarks();
                    
                }
                else if (option == 3)
                {
                   
                   
                    
                   
                }
                else if (option == 4)
                {
                    CalculateGradeProfile();
                    OutputGradeProfile();
                    
                }
                else if (option == 5)
                {
                    Console.WriteLine(" You have exited the program");
                }
                else
                {
                    Console.WriteLine(" That was not an option");
                    
                }
            }
            else
            {
                Console.WriteLine(" Use a number to pick your choice ");
                
            }
        }

        /// <summary>
        /// Input for marks
        /// </summary>
        private void InputMarks()
        {
            for (int i = 0; i < Number_of_Students; i++)
            {
                Marks[i] = (int)ConsoleHelper.InputNumber($" Pls enter mark for {Students[i]} ", 0, 100);
                Grades[i] = ConvertMarktoGrade(Marks[i]);
            }
        }

        /// <summary>
        /// Conversion of into Grades
        /// </summary>
        public Grades ConvertMarktoGrade(int mark)
        {
            if (mark < 40)
            {
                return App03.Grades.F;
            }
            else if (mark < 50)
            {
                return App03.Grades.D;
            }
            else if (mark < 60)
            {
                return App03.Grades.C;
            }
            else if (mark < 70)
            {
                return App03.Grades.B;
            }
            else
            {
                return App03.Grades.A;
            }

             if (mark <= 35)
            {
                Console.WriteLine("Grade is F");
            }
            else if (mark >= 40 && percentage <= 49)
            {
                Console.WriteLine("Grade is D");
            }
            else if (mark >= 50 && percentage <= 59)
            {
                Console.WriteLine("Grade is C");
            }
            else if (mark >= 60 && percentage <= 69)
            {
                Console.WriteLine("Grade is B");
            }
            else if (mark >= 70 && percentage <= 100)
            {
                Console.WriteLine("Grade is A");

            }

        }

        /// <summary>
        /// The marks output
        /// </summary>
        private void OutputMarks()
        {
            for (int i = 0; i < Number_of_Students; i++)
            {
                Console.WriteLine($" {Students[i]} mark is {Marks[i]} and grade is {Grades[i]}");
            }
        }

        

        

       

        /// <summary>
        /// calculates the precentage of students how got each grade 
        /// </summary>
        public void CalculateGradeProfile()
        {
            foreach (Grades grade in Grades)
            {
                Gradeprofile[(int)grade] += 1;
            }

            for (int i = 0; i < Gradeprofile.Length; i++)
            {
                Gradeprofile[i] = Gradeprofile[i] * 100 / Number_of_Students;
            }
        }

        /// <summary>
        /// outputs the grade profile
        /// </summary>
        private void OutputGradeProfile()
        {
            foreach (Grades val in Enum.GetValues(typeof(Grades)))
            {
                Console.WriteLine($" The percentage of students that got {val} is {Gradeprofile[(int)val]} %");
            }
        }
    }
}