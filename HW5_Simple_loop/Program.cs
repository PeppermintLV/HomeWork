using System;

namespace HW5_Simple_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program where the user enters number N. Output all the numbers from 1 to N except the number 5 and number 10.
            Console.WriteLine("Please enter a number:");
            string userNr = Console.ReadLine();
            int N;
            bool isNr= int.TryParse(userNr, out N);
            int n;
            n = 0;

            if (isNr)
            {
                while (n <= N)
                {
                    if (n == 5 || n == 10)
                    {
                        n++;
                        continue;  
                        
                    }
                    else
                    {
                        Console.WriteLine($"This is {n}");
                       
                    }
                    n++;
                }
            }
            
        }
    }
}
