using System;

namespace CW5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user if he wants lunch. If the user writes TRUE then print "Your lunch is ready", if the user wrote FALSE, then print "There is no lunch for you". 
            //IF ELSE condition criteria should use bool type variable, not a string type variable. To get a bool type variable from the user use bool.Parse.


            Console.WriteLine("Do you want lunch? Please answer TRUE or FALSE!");
            string input = Console.ReadLine();
            bool answer = bool.Parse(input);
            //Console.WriteLine($"You have entered {answer}");

            if (answer)
            {
                Console.WriteLine($"Your lunch is ready!");

            }
            else
            {
                Console.WriteLine($"There is no lunch for you!");

            }


        }
    }
}
