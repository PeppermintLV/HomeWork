using System;

namespace HW6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user to input a whole number. If the entered value is not a whole number, 
            //notify about the error and make the user input so many times until the input is a correct value of whole number (use while). 
            //When the entered value is correct print it out.



            Console.WriteLine("Please input a whole number!");
            string input1 = Console.ReadLine();

            int n1;
            bool isint = int.TryParse(input1, out n1);

            while (!isint)
            {

                Console.WriteLine("Error");
                Console.WriteLine("Please input a whole number!");
                input1 = Console.ReadLine();
                isint = int.TryParse(input1, out n1);
            }
            Console.WriteLine($"You input {n1}!");

        }
    }
}
