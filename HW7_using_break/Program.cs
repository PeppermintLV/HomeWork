using System;

namespace HW7_using_break
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an int array of values 1,1,1,0,1,1,1, 1. Print all the values until you find 0, once 0 is found, exit the loop. Use break;

            int[] arr = new int[] { 1, 1, 1, 0, 1, 1, 1, 1 };

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    Console.WriteLine(arr[i]);
                }
                else
                {
                    break;
                }
            }

            
        }
    }
}
