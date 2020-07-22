using System;

namespace HW_IF2
{
    class Program
    {
        static void Main(string[] args)
        {
            //We have 30 euro in our bank account. Ask the user how much money would he like to take. Depending on the answer, tell the user appropriate answer – print it in Console screen.

            Console.Write("Please enter the amount of money You would like to withdraw:");
            string MoneyInput;
            MoneyInput = Console.ReadLine();
            int MoneyWalue = int.Parse(MoneyInput);

            if (MoneyWalue > 0 && MoneyWalue < 30)
            {
                Console.WriteLine("You can withdraw this amount!");
            }
            else if (MoneyWalue > 30)
            {
                Console.WriteLine("Your funds are insufficient for this withdrawal!");
            }

            
        }
    }
}
