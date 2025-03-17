using System;

namespace Practicing
{
    class Program
    {
        static void Main(string[] args)
        {
            float myNum = 5.65F;

            string fName = getName("Please enter first name: ");

            string lName = getName("Please enter last name: ");

            int random = inputValid("Please enter an integer: ");


            bool ifPrint = random >= 25;
            int findMax = Math.Max(fName.Length, lName.Length);

            Console.WriteLine(fName.Length > lName.Length
                ? "First name is longer than last"
                : "Last name is longer than first");

            Console.WriteLine($"Full Name is: {fName} {lName}");
            Console.WriteLine($"Result is: {myNum}");
            Console.WriteLine($"Status is: {ifPrint}");
            Console.WriteLine($"Max name count is: {findMax}");



            static string getName(string message)
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

        }

    }
}