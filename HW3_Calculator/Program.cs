using System;

namespace HW3_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create console application, which will ask for 2 numbers and for some kind of mathematical action (+,-,*,/). 
            //Print the result of this action in Console. For example, 5+3=8


            Console.WriteLine("Please input the first number:");
            string temp1 = Console.ReadLine();
            int number1 = int.Parse(temp1);

            Console.WriteLine("Please input the second number:");
            string temp2 = Console.ReadLine();
            int number2 = int.Parse(temp2);

            Console.WriteLine("Please input the desired mathematical action (+,-,*,/):");
            string action = Console.ReadLine();

            switch (action)
            {
                case "+":
                    Console.WriteLine($"The result is {number1 + number2}");
                    break;

                case "-":
                    Console.WriteLine($"The result is {number1-number2}");

                    break;

                case "*":
                    Console.WriteLine($"The result is {number1*number2}");

                    break;

                case "/":
                    Console.WriteLine($"The result is {number1/number2}");

                    break;

                default:
                    Console.WriteLine("You have not entered one of the simbols given (+,-,*,/)!");
                    break;

            }
        }
    }
}
