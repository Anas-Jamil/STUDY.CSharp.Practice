using System;

namespace Practicing
{
    class Program
    {
        static void Main(string[] args)
        {
            float myNum = 5.65F;
            int random;

            Console.WriteLine("Please enter first name: ");
            string fName = Console.ReadLine();

            Console.WriteLine("Please enter last name: ");
            string lName = Console.ReadLine();

            Console.WriteLine("Please enter an integer: ");
            while (!int.TryParse(Console.ReadLine(), out random))
            {
                Console.WriteLine("Invalid Input! Try Again: ");
            }

            bool ifPrint = random >= 25;
            int findMax = Math.Max(fName.Length, lName.Length);

            Console.WriteLine(fName.Length > lName.Length
                ? "First name is longer than last"
                : "Last name is longer than first");

            Console.WriteLine($"Full Name is: {fName}");
            Console.WriteLine($"Result is: {myNum}");
            Console.WriteLine($"Status is: {ifPrint}");
            Console.WriteLine($"Max name count is: {findMax}");

        }

    }
}