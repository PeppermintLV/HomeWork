using System;

namespace HW6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an int array 100, 200, 233, 66, 77, 98. Print the first and the last element values. 
            //Change the element value of 200 to 500, print the value before and after the change. 

            //array for int data type
            int[] array1 = new int[] { 100, 200, 233, 66, 77, 90 };
            Console.WriteLine($"Array start {array1[0]}");
            Console.WriteLine($"Array end {array1[5]}");

            Console.WriteLine($"Array old second place {array1[1]}");
            array1[1] = 500;
            Console.WriteLine($"Array new second place {array1[1]}");


        }
    }
}
