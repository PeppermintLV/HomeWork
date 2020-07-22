using System;

namespace CW5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define a bool variable, which has the initial value of TRUE. 
            //Create a while loop, which repeats itself while the variable value is TRUE. Change the variable value to FALSE when loop has executed 20 times.

            //first solution
            bool first = true;
            int n = 0;

            while (first)
            {
                if (n == 19)
                {
                    first = false;
                }
                Console.WriteLine($"running {n}");

                n++;
            }

            //second solution
            int n2 = 0;
            bool second = true;
            while (second)
            {
                Console.WriteLine($"going {n2}");
                n2++;
                second = n2 <= 19;
            }

        }
    }
}
