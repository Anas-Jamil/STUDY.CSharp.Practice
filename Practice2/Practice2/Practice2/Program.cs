using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

// A very simple in console calculator that also has test cases

namespace Practicing2
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation = getOperation("What operation would you like to use? (+,-,/,*): ");

            float num1 = getNumber("Please enter your first numer");
            float num2 = getNumber("Please enter your second numer");

            float result = 0;

            if (operation == "+")
            {
                result = Additon(num1, num2);
            } else if (operation == "-") 
            {
                result =  Subtraction(num1, num2);
            } else if (operation == "/") 
            {
                result = Divide(num1, num2);
            } else if (operation == "*")
            {
                result = Multiplication(num1, num2); 
            }
            else
            {
                Console.WriteLine("Error");

            }
            Math.Round(result, 2);
            Console.WriteLine($"Result: {result}");
        }

        static float getNumber(string message)
        {
            float number; 
            Console.WriteLine(message);
            while(!float.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid input Please try again");
            }
            return number;
        }
        static string getOperation(string message)
        {
            Console.WriteLine(message);
            string operation = Console.ReadLine();
            while(operation != "+" && operation != "-" && operation != "/" && operation != "*") 
            {
                Console.WriteLine("Invalid operation, please enter one of (+,-,/,*)");
                operation = Console.ReadLine();
            }
            return operation;
        }
        
        static float Additon(float num1, float num2) 
        {
            
            return num1 + num2;
        }

        static float Subtraction(float num1, float num2)
        {
            return num1 - num2;
        }

        static float Multiplication(float num1, float num2)
        {
            return num1 * num2; 
        }

        static float Divide(float num1, float num2)
        {
            return num1 / num2;
        }
        
    }
}