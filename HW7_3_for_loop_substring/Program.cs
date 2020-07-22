using System;

namespace HW7_3_for_loop_substring
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Create a string type array with some names (At least 5).
            //1.Print all the names.
            //2.Print only those names who start with "J".
            //Use Substring method and for loop.

            string[] arr = new string[] { "Joe", "Ann", "Jane", "Sam", "Ron" };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(($"The name is {arr[i]}"));
            }

            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                string first = arr[i].Substring(0, 1);
                if (first == "J")
                {
                    Console.WriteLine(($"The name is {arr[i]}"));

                }
            }





         
        }
    }
}
