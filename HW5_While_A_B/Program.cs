using System;

namespace HW5_While_A_B
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program where the user enters two numbers A and B. Output all the numbers between A and B



            Console.WriteLine("Please enter the lowest number!");
            string userNr1 = Console.ReadLine();
            int N1;
            N1 = int.Parse(userNr1);


            Console.WriteLine("Please enter the highest number!");
            string userNr2 = Console.ReadLine();
            int N2;
            N2 = int.Parse(userNr2);
            Console.WriteLine($"{N1}");

            int n = N1;

            if (N1<N2)
            {
                n++;

                while (n != N2)
                {
                    Console.WriteLine($"this is the number between: {n}");
                    n++;
                }
            }

            else if (N1>N2)
            {
                n--;

                while (n != N2)
                {
                    Console.WriteLine($"this is the number between: {n}");
                    n--;
                }
            }
                



        }
    }
}
