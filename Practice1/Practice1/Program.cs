using System;

namespace Practicing
{
    class Program
    {
        static void Main(string[] args)
        {
            float myNum = 5.65F;

            string fName = getInput("Please enter first name: ");

            string lName = getInput("Please enter last name: ");

            int random = inputValid("Please enter an integer: ");

            string breaker = getInput("Please enter a message to break");


            bool ifPrint = random >= 25;
            int findMax = Math.Max(fName.Length, lName.Length);

            nameLengths(fName, lName);
            displayResults(fName, lName, myNum, ifPrint, findMax);
            breakMessage(breaker);
            


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