// Day 2: Conditional Statements and Loops
// Learn if-else, switch, for, while, and do-while loops.
// Task:
//Write a program to calculate the factorial of a number.Upload code to GitHub.

using System;
namespace ConditionalStatementsAndLoops
{
    class Statements
    {
        static void Main(string[] args)
        {
            
            int ageAllowed = 18;
            Console.WriteLine("If else statement");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine()!);

            // If else statements

            if(ageAllowed <= age)
            {
                Console.WriteLine("You are allowed to enter.\n");
            }
            else
            {
                Console.WriteLine("You are not allowed to enter.");
                Console.WriteLine("-----------------------------");
            }

            //Switch statement
            Console.WriteLine("Switch statement");
            Console.WriteLine("-------------------------------:");
            Console.WriteLine("Please Enter age:");
            int ageInput= int.Parse(Console.ReadLine()!);
            
            switch(ageInput)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                    Console.WriteLine("Too Young");
                    Console.WriteLine("\n");
                    break;

                case 18:
                    Console.WriteLine("Old Enough");
                    Console.WriteLine("\n");
                    break;

                default:
                    Console.WriteLine("You are eligible to enter:");
                    Console.WriteLine("\n");
                    break;
                
            }
           
           // for loop
           Console.WriteLine("-------------------");
           Console.WriteLine("For loop");
           Console.WriteLine("-------------------");
           for(int i=0; i<=age; i++)
           {
             Console.WriteLine(i);
           }

           // while loop
           Console.WriteLine("-------------------");
           Console.WriteLine("While loop");
           Console.WriteLine("-------------------");
           int num=0;
           while(num<=age)
           {
             Console.WriteLine(num);
             num++;
           }
           
           // do-while loop
           Console.WriteLine("-------------------");
           Console.WriteLine("Do-while loop");
           Console.WriteLine("-------------------");
           int num1=0;
           do{
             Console.WriteLine(num1);
             num1++;
           }while(num1<=age);

           //Write a program to calculate the factorial of a number.
            Console.WriteLine("-------------------");
            Console.WriteLine("Factorial Calculation");
            Console.WriteLine("-------------------");
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine()!);
            long factorial = 1;
            for(int i=1; i<=number; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("Factorial of " + number + " is: " + factorial);
        }
    }
    
}