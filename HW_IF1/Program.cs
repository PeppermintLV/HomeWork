using System;

namespace HW_IF1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Get a number from a user. If the number is between 0 and 10 then print out “A” and if the value is larger than 10, then print out “B”.

            Console.Write("Please enter a number:");
            string IevaditaisSkaitlis;
            IevaditaisSkaitlis = Console.ReadLine();
            int cipars = Convert.ToInt32(IevaditaisSkaitlis);

            if (cipars > 0 && cipars < 10)
            {
                Console.WriteLine("A");
            }
            else if (cipars > 10)
            {
                Console.WriteLine("B");
            }


            Console.Write("Please enter a number:");
            string IevaditaisSkaitlis2;
            IevaditaisSkaitlis2 = Console.ReadLine();
            int cipars2 = int.Parse(IevaditaisSkaitlis2);

            if (cipars2 > 0 && cipars2 < 10)
            {
                Console.WriteLine("A");
            }
            else if (cipars2 > 10)
            {
                Console.WriteLine("B");
            }
        }
    }
}
