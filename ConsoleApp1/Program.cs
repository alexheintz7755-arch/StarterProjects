using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace ConsoleApp1
{
    class Program
{
    static void Main(string[] args)
    {











            // THIS CALCULATES HOW MUCH YOU MADE WORKING A CERTAIN AMOUNT OF HOURS.
            // new AmountMadeAtWork();




            // I used a different class to intialize this program. It is basically calling it like a CONFIG.
            /*
            Game game1 = new Game("Halo", "Bungie", 4.5, 2001);


            Console.WriteLine(game1.title + " was made by " + game1.studio + " in " + game1.year );



            */

            //FOR AND WHILE LOOPS 


            /*
            int number = 4;
            int power = 5;
            int answer = 1;
            int step = 1;

            while ( step <= power)
            {
                answer *= number; 
                step++;
                Console.WriteLine(answer);
            }
            Console.ReadLine();
            */





            // Calculator

            /*
            Console.WriteLine("Enter your first number: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your operator (+, -, *, /) ");
            string myOperator = Console.ReadLine();
            if (myOperator.Length > 1)
            {
                Console.WriteLine("Please enter a valid operator: ");
                myOperator = Console.ReadLine();

            }
           
            Console.WriteLine("Enter your second number: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            if (myOperator == "+")
            {
                Console.WriteLine(firstNumber + secondNumber);
            }
            if (myOperator == "-")
            {
                Console.WriteLine(firstNumber - secondNumber);
            }
            if (myOperator == "*")
            {
                Console.WriteLine(firstNumber * secondNumber);
            }
            if (myOperator == "/")
            {
                Console.WriteLine(firstNumber / secondNumber);
            }

            */



            // STRINGS


            /*
         
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your height in inches: ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your favorite color? ");
            string color= Console.ReadLine();
            int feet = height / 12;
            int inches = height % 12;
            

            Console.WriteLine("Your name  is " + name + ".");
            Console.WriteLine("You are " + age + " years old.");
            Console.WriteLine("Your height is " + feet + "'" + inches + " feet.");
            age = age + 1;
            Console.WriteLine("Your favorite color is " + color + ".");
            Console.WriteLine("But next year you will be " + age + "."  );
            Console.ReadLine();
            */

        }
}

}

 