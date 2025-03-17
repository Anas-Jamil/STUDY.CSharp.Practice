using System;

namespace Practicing
{
    class Program
    {
        static void Main(string[] args)
        {
            float myNum = 5.65F;
            int plus = 20 + 4;
            bool ifPrint = false;

            Console.WriteLine("Please enter first name: ");
            string fName = Console.ReadLine();
            Console.WriteLine("Please enter last name: ");
            string lName = Console.ReadLine();

            Console.WriteLine("Please enter an integer: ");
            int random = Convert.ToInt32(Console.ReadLine());

            if (random >= 25)
            {
                ifPrint = true;
            }


            Console.WriteLine($"Full Name is: {fName} {lName}");
            Console.WriteLine("Result is: " + plus + " " + myNum);
            Console.WriteLine("Status is: " + ifPrint);
            Console.WriteLine("Max name count is: " + Math.Max(fName.Length, lName.Length));

        }

    }
}