using System;

namespace HW7_2_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define int[] - array int[] numbers = { 1, 3, 4, 8, 0, 23 }; Print all the values of the array and afterwards print only the values which are larger than 5.
            //break and continue works for any kind of loop

            int[] numbersarray = new int[] { 1, 3, 4, 8, 0, 23 };


            for (int i = 0; i < numbersarray.Length; i++)
            {
                Console.WriteLine(($"Counter is {i} and number is {numbersarray[i]}"));
            }

            for (int i = 0; i < numbersarray.Length; i++)
            {
                if (numbersarray[i] > 5)
                {
                    Console.WriteLine(($"Counter is {i} and number over 5 is {numbersarray[i]}"));
                }
                
            }



            //first way that I didnt want to erase

            //int[] numbersarray = new int[] { 1, 3, 4, 8, 0, 23 };


            //for (int i = 0; i < numbersarray.Length; i++)
            //{
            //    Console.WriteLine(($"Counter is {i} and number is {numbersarray[i]}"));
            //}

            //for (int i = 0; i < numbersarray.Length; i++)
            //{
            //    if (numbersarray[i] < 5)
            //    {
            //        continue;
            //    }
            //    else if (numbersarray[i] > 5)
            //    {
            //        Console.WriteLine(($"Counter is {i} and number over 5 is {numbersarray[i]}"));
            //    }
            //}
        }
    }
}
