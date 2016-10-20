using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameOfThrees
{
    class Program
    {
        // Create a program that plays the 'game of threes'
        // Take a large random number
        // If it's divisible by 3, divide it by 3
        // If not, add or subtract 1 to make it divisible by three
        // Repeat until number is 3
        static void Main(string[] args)
        {
            // Check that arguments are okay
            if (args.Length == 0)
            {
                Console.WriteLine("Please enter a numeric argument");
                Environment.Exit(0);
            }
            int startingNumber;
            if (!Int32.TryParse(args[0], out startingNumber))
            {
                Console.WriteLine("Enter valid input - an integer. Press any key to continue");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.WriteLine(startingNumber);
            int num = startingNumber;

            // Begin divisions
            while (num != 1)
            {
                if (num % 3 == 0)
                {
                    Console.WriteLine(num + " 0");
                }
                else if ((num + 1) % 3 == 0)
                {
                    num += 1;
                    Console.WriteLine(num + " +1");
                }
                else if ((num - 1) % 3 == 0)
                {
                    num -= 1;
                    Console.WriteLine(num + " -1");
                }
                // If both cases above are false then num is divisible as is.
                num = num / 3;
            }
            Console.WriteLine(num);


            // Wait before exiting
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}
