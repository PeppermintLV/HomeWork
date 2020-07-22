using System;

namespace HW6_Digit_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program which calculates the sum of digits of the entered number (e.g. 245 sum of digits is 2 + 4 + 5 = 11).




            //Console.WriteLine("Please enter a number with multiple digit:!");
            //string input1 = Console.ReadLine();
            //string firstdigit = input1.Substring(0, 1);
            //int digit1 = int.Parse(firstdigit);

            //string firstdigit = input1.Substring(0, 2);
            //int digit1 = int.Parse(firstdigit);

            //string firstdigit = input1.Substring(0, 3);
            //int digit1 = int.Parse(firstdigit);
            ////Console.WriteLine(firstdigit);
            ///

            //Console.WriteLine("Please enter a number:");
            //string input1 = Console.ReadLine();
            ////length



            Console.WriteLine("Please enter a number:");
            string Userinput = Console.ReadLine();
            int sum = 0;

            int counter = 0;
            while (counter < Userinput.Length)
            {
                Console.WriteLine($"Iteration {counter}");
                string firstdigit = Userinput.Substring(counter,1);
                int digit1 = int.Parse(firstdigit);
                sum += digit1;
                counter++;

            }

        
            Console.WriteLine(sum);
           



        }
    }
}
