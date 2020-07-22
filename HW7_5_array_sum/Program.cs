using System;

namespace HW7_5_array_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define an int array with 8 values. Sum only numbers which have a value more than 10, then print this sum

            int[] arr = new int[] { 11, 2, 22, 3, 44, 5, 7, 13 };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 10)
                {
                    sum += arr[i];
                }
            }
                        
            Console.WriteLine(sum);
        }
    }
}
