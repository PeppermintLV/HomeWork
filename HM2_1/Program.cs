using System;

namespace HM2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a console application which will ask for a name and then prints it out. (Use Console.WriteLine and Console.ReadLine)
            string vards;

            Console.WriteLine("Kads ir jusu vards?");
            vards = Console.ReadLine();
            Console.WriteLine("Jusu vards ir {0}?", vards);
            Console.ReadKey();
        }
    }
}
