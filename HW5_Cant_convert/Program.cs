using System;

namespace HW5_Cant_convert
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a console application which will read 4 text values from user and prints out only those, who can’t be converted as a number of data type int.

            Console.WriteLine("Please input the first number:");
            string temp1 = Console.ReadLine();
            int n1;
            bool isint = int.TryParse(temp1, out n1);

            Console.WriteLine("Please input the second number:");
            string temp2 = Console.ReadLine();
            int n2;
            bool isint2 = int.TryParse(temp2, out n2);

            Console.WriteLine("Please input the third number:");
            string temp3 = Console.ReadLine();
            int n3;
            bool isint3 = int.TryParse(temp3, out n3);

            Console.WriteLine("Please input the fourth number:");
            string temp4 = Console.ReadLine();
            int n4;
            bool isint4 = int.TryParse(temp4, out n4);

            if (!isint)
            {
                Console.WriteLine($"Number input of '{temp1}' was incorrect!");

            }
            if (!isint2)
            {
                Console.WriteLine($"Number input of '{temp2}' was incorrect!");

            }
            if (!isint3)
            {
                Console.WriteLine($"Number input of '{temp3}' was incorrect!");

            }
            if (!isint4)
            {
                Console.WriteLine($"Number input of '{temp4}' was incorrect!");

            }
        }
    }
}
