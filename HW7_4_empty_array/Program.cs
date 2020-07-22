using System;

namespace HW7_4_empty_array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define an empty int array with 10 spaces for values. Define a loop which will fill this array with values. Make sure all of the values are filled with different values. 
            //Therefore use user input or assign loop counter variable.

            string[] arr = new string[] { " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Please write a name:");
                arr[i] = (Console.ReadLine());
                Console.WriteLine(arr[i]);
            }


        }
    }
}
