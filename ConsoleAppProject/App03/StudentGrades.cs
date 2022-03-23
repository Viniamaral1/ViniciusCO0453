using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;
using System.Linq;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// At the moment this class just tests the
    /// Grades enumeration names and descriptions
    /// </summary>
    public class StudentGrades
    {
        private const string Format = "{0} -- {1} -- {2} -- {3} -- {4}";
        private readonly int percentage;


        public string Name { get; set; }

        private string program;

        public string GetProgram()
        {
            return program;
        }

        public void SetProgram(string value)
        {
            program = value;
        }

        public StudentGrades(string program)
        {
            this.SetProgram(program);
        }

        public StudentGrades()
        {
        }

        public int Mark { get; set; }
        public int Grade { get; set; }
        public object Students { get => students; set => students = value; }

        
        private object students;

        
        
            

            


        public override string ToString()
        {
            return string.Format(Format, Name, GetProgram(), Mark, Grade);
        }
        public void Run()
        {
            Outputheading();
            CaculateGrades();
        }

        private void Outputheading()
        {
            Console.WriteLine("    ===========================  ");
            Console.WriteLine("     App03;Students Grade  ");
            Console.WriteLine("       By Vinicius Do Amaral     ");
            Console.WriteLine("    ===========================  ");
        }

        internal void RUN()
        {
           StudentGrades App03 = new StudentGrades();
            App03.RUN();
        }

        private void CaculateGrades()
        {
            if (percentage <= 35)
            {
                Console.WriteLine("Grade is F");
            }
            else if (percentage >= 40 && percentage <= 49)
            {
                Console.WriteLine("Grade is D");
            }
            else if (percentage >= 50 && percentage <= 59)
            {
                Console.WriteLine("Grade is C");
            }
            else if (percentage >= 60 && percentage <= 69)
            {
                Console.WriteLine("Grade is B");
            }
            else if (percentage >= 70 && percentage <= 100)
            {
                Console.WriteLine("Grade is A");
            }
        }
         


        class Program
        {


            private static void Student ()
            {
                Student sOne = new Student()
                {
                    
                    Name = "Lara",
                    Program = "Computing",
                    Mark = "49",
                    Grade = "D"
                };

                Student sTwo = new Student()
                {
                    Name = "Lianne",
                    Program = "Nurse",
                    Mark = "79",
                    Grade = "A"
                };

                Student sThree = new Student()
                {
                    Name = "Jonh",
                    Program = "Medicine",
                    Mark = "66",
                    Grade = "B"
                };

                Student sFour = new Student()
                {
                    Name = "Donald",
                    Program = "Economic",
                    Mark = "55",
                    Grade = "C"
                };

                Student sFive = new Student()
                {
                    Name = "Silvia",
                    Program = "Music",
                    Mark = "41",
                    Grade = "D"
                };

                Student sSix = new Student()
                {
                    Name = "Eli",
                    Program = "Art",
                    Mark = "33",
                    Grade = "F"
                };

                Student sSeven = new Student()
                {
                    Name = "Jimmie",
                    Program = "Coach",
                    Mark = "69",
                    Grade = "B"
                };

                Student sEight = new Student()
                {
                    Name = "Max",
                    Program = "Cyber security",
                    Mark = "47",
                    Grade = "D"
                };

                Student sNine = new Student()
                {
                    Name = "Vini",
                    Program = "A.I",
                    Mark = "100",
                    Grade = "A"
                };

                Student sTen = new Student()
                {
                    Name = "Josh",
                    Program = "Aviation",
                    Mark = "100",
                    Grade = "A"
                };

                List<Student> StudentList = new List<Student>
                {
                    sOne,
                    sTwo,
                    sThree,
                    sFour,
                    sFive,
                    sSix,
                    sSeven,
                    sEight,
                    sNine,
                    sTen,

                };

                Student s = StudentList[0];


                Console.WriteLine("Student Id  is {0}, Student Name is {1}, Student Gender is {2}, Student Marks is {3}", s.Name, s.Program, s.Mark, s.Grade);
            }
        }
    }

    internal class Student
    {
        public string Name { get; internal set; }
        public string Program { get; internal set; }
        public string Mark { get; internal set; }
        public string Grade { get; internal set; }
    }

   
}



     
      
      

     



