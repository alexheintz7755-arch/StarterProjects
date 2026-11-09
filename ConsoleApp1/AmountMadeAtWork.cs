using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace ConsoleApp1{
        // Class that calculates amount made at work
        class AmountMadeAtWork
    {
        public AmountMadeAtWork()
        {
            Console.WriteLine("Enter the amount of hours you worked: ");
            double hours = ReadDoubleFromConsole();

            Console.WriteLine("Enter the amount you get paid per hour: ");
            double money = ReadDoubleFromConsole();

            double amountMade = hours * money;
            Console.WriteLine($"You made ${amountMade} in {hours} hours!");
            double load = money * 1000;
            Console.WriteLine("If you worked 1000 hours you would make $" + load + "!");
        }

        // Helper method for safe numeric input
        private double ReadDoubleFromConsole()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (double.TryParse(input, out double value))
                {
                    return value;
                }
                Console.WriteLine("Invalid number. Please enter a valid numeric value:");
            }
        }

    }

}