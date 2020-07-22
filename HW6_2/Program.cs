using System;

namespace HW6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a string type array with values "John", "Peter", "Andrew".
            //Print the second value("Peter"). Change the third value from " Andrew" uz "John".

            string[] array1 = new string[] { "John", "Peter", "Andrew" };
            Console.WriteLine(array1[1]);

            Console.WriteLine(array1[2]);
            array1[2] = "John";
            Console.WriteLine(array1[2]);

        }
    }
}
