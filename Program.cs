using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ask user to input integer(0-100)
            Console.Write("Enter the grade(0-100): ");
            int grade = int.Parse(Console.ReadLine());

            //Check if the user enter int 0-100
            if (grade >= 0 && grade <= 100)
            {   
                //Check if the grade is 90 - 100
                if (grade >= 90 && grade <= 100)
                {
                    Console.WriteLine("Your grade is: A");
                }
                //Check if the grade is 80-89
                else if (grade >= 80 && grade <= 89)
                {
                    Console.WriteLine("Your grade is: B");
                }
                //Check if the grade is 70-79
                else if (grade >= 70 && grade <= 79)
                {
                    Console.WriteLine("Your grade is: C");
                }
                //Check if the grade is 60-69
                else if (grade >= 60 && grade <= 69)
                {
                    Console.WriteLine("Your grade is: D");
                }
                //check if grade is <60
                else if(grade < 60)
                {
                    Console.WriteLine("Your grade is: F");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input: Please enter # between 0-100");
            }
        }
    }
}

