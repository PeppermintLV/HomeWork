using System;

namespace HM3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //We have a house with 5 floors and a basement. User will be asked to input an item from the house, for example, “table”, 
            //and our program must tell in which floor the item must be placed. Rules for item placement in the house: 
            //Items who start with the letters a,b,c,d are placed in the first floor. Items who start with the letters e,f,g,h are placed in the second floor. 
            //The following letters in a similar manner are place in floor nr 3., nr 4., nr.5. All the other items are placed in the basement.

            Console.WriteLine("Please enter your desired item to store!");
            string thing;
            thing = Console.ReadLine();

            if (thing.Substring(0, 1) == "a" || thing.Substring(0, 1) == "b" || thing.Substring(0, 1) == "c" || thing.Substring(0, 1) == "d")
            {
                Console.WriteLine("Item must be placed in the first floor!");
            }

            else if (thing.Substring(0, 1) == "e" || thing.Substring(0, 1) == "f" || thing.Substring(0, 1) == "g" || thing.Substring(0, 1) == "h")
            {
                Console.WriteLine("Item must be placed in the second floor!");
            }
            else if (thing.Substring(0, 1) == "i" || thing.Substring(0, 1) == "j" || thing.Substring(0, 1) == "k" || thing.Substring(0, 1) == "l")
            {
                Console.WriteLine("Item must be placed in the third floor!");
            }
            else if (thing.Substring(0, 1) == "m" || thing.Substring(0, 1) == "n" || thing.Substring(0, 1) == "o" || thing.Substring(0, 1) == "p")
            {
                Console.WriteLine("Item must be placed in the fourth floor!");
            }
            else if (thing.Substring(0, 1) == "q" || thing.Substring(0, 1) == "r" || thing.Substring(0, 1) == "s" || thing.Substring(0, 1) == "t")
            {
                Console.WriteLine("Item must be placed in the fifth floor!");
            }
            else
            {
                Console.WriteLine("Item must be placed in the basement!");
            }
        }
    }
}
