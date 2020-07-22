using System;

namespace HM2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create console application and ask the user for name and surname. Print both values in the format of “Name Surname”. 
            //Modify the program and print the name and surname again in format “N. Surname”. To get the first letter use name.Substring(0,1). 
            //The 'name' is the variable where you store the value.

            //https://docs.microsoft.com/en-us/dotnet/api/system.string.substring?view=netcore-3.1
            
           

            Console.WriteLine("Kads ir jusu vards?");
            string name;
            name = Console.ReadLine();
            Console.WriteLine("Kads ir jusu uzvards?");
            string surname;
            surname = Console.ReadLine();

            Console.WriteLine($"Jus sauc {name} {surname}?");
            
            Console.WriteLine($"Varbut Jus saukt {name.Substring(0, 1)}. {surname}?");



        }
    }
}
