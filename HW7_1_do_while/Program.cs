using System;

namespace HW7_1_do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a string type array with peoples names. Use do while loop to print all of the names
            
            
            //var is a variable that can be any data type, but you have to set a value from the start
            //do while will always execute at least once


            string[] arraynames1 = new string[] { "Jim", "Jane", "Sam" };
            Console.WriteLine(arraynames1[1]);

            int counter = 0;
            do
            {
                Console.WriteLine($"Counter is {counter} and name is {arraynames1[counter]}");
                counter++;

            } while (counter< arraynames1.Length);
        }
    }
}
