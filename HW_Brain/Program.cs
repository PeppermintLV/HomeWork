using System;

namespace HW_Brain
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a console application ask for two game contestant names. 
            //Then ask 3 times to input first player points and then 3 times to input second player points. Print out the winners name (the one who has to most points).

            Console.WriteLine("Please enter the name of the first contestant:");
            string first = Console.ReadLine();
            Console.WriteLine("Please enter the name of the second contestant:");
            string second = Console.ReadLine();

            Console.WriteLine("Please enter the points for the first contestant:");
            string Tpoint11 = Console.ReadLine();
            int point11 = int.Parse(Tpoint11);
            Console.WriteLine("Please enter the points for the first contestant:");
            string Tpoint12 = Console.ReadLine();
            int point12 = int.Parse(Tpoint12);
            Console.WriteLine("Please enter the points for the first contestant:");
            string Tpoint13 = Console.ReadLine();
            int point13 = int.Parse(Tpoint13);

            Console.WriteLine("Please enter the points for the second contestant:");
            string Tpoint21 = Console.ReadLine();
            int point21 = int.Parse(Tpoint21); 
            Console.WriteLine("Please enter the points for the second contestant:");
            string Tpoint22 = Console.ReadLine();
            int point22 = int.Parse(Tpoint22);
            Console.WriteLine("Please enter the points for the second contestant:");
            string Tpoint23 = Console.ReadLine();
            int point23 = int.Parse(Tpoint23);

            if (point11 + point12 + point13 > point21 + point22 + point23)
            {
                Console.WriteLine($"The winner ir player {first}!");
            }
            else if (point11 + point12 + point13 < point21 + point22 + point23)
            {
                Console.WriteLine($"The winner ir player {second}!");
            }
            else
            {
                Console.WriteLine("Neizšķirts!");
            }
        }
    }
}
