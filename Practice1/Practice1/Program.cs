using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Practicing
{
    class Program
    {
        static void Main(string[] args)
        {
            float myNum = 5.65F;

            string fName = getInput("Please enter first name: ");

            string lName = getInput("Please enter last name: ");

            string breaker = getInput("Please enter a message to break");

            int DOW = dayOfWeekValid("Please enter day of week (1-7, monday-sunday)");

            int random = inputValid("Please enter an integer: ");


            bool ifPrint = random >= 25;
            int findMax = Math.Max(fName.Length, lName.Length);

            nameLengths(fName, lName);
            displayResults(fName, lName, myNum, ifPrint, findMax);
            breakMessage(breaker);
            dayOfWeekCase(DOW);
            


            static string breakMessage(string breaker)
            {
                Console.WriteLine("Your broken message is: ");
                for (int i = 0; i < breaker.Length; i++)
                {
                    Console.WriteLine(breaker[i]);
                }
                return breaker;
            }

            static string getInput(string message)
            {
                Console.WriteLine(message);
                return Console.ReadLine();

            }

            static int inputValid(string message)
            {
                int number;
                Console.WriteLine(message);
                while (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Invalid Input! Try Again: ");
                }
                return number;

            }

            static int dayOfWeekValid(string message)
            {
                int dayOfWeek;
                Console.WriteLine(message);
                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out dayOfWeek))
                    {
                        if (dayOfWeek >= 1 && dayOfWeek <= 7)
                        {
                            return dayOfWeek;
                        } 
                        else
                        {
                            Console.WriteLine("Please enter an input between 1-7: ");
                        }
                    } 
                    else
                    {
                        Console.WriteLine("Please enter a valid input(integer): ");
                    }
                }

            }

            static void dayOfWeekCase(int dayOfWeek)
            {
                Console.WriteLine("Your Chosen day: ");
                switch(dayOfWeek) 
                {
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
                    case 7:
                        Console.WriteLine("Sunday");
                        break;
                    default: 
                        Console.WriteLine("Day of Week");
                        break;
                }
            }

            static void nameLengths(string fName, string lName)
            {
                Console.WriteLine(fName.Length > lName.Length
                    ? "First name is longer than last"
                    : "Last name is longer than first");

            }

            static void displayResults(string fName, string lName, float myNum, bool ifPrint, int findMax)
            {
                Console.WriteLine($"Full Name is: {fName} {lName}");
                Console.WriteLine($"Result is: {myNum}");
                Console.WriteLine($"Status is: {ifPrint}");
                Console.WriteLine($"Max name count is: {findMax}");
            } 

        }

    }
}