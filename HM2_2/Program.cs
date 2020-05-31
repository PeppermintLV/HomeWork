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
            string name;
            int found;

            Console.WriteLine("Kads ir jusu vards?");
            name = Console.ReadLine();
            found = name.IndexOf(" ");

            Console.WriteLine("Jusu saukt {0} vai {1}. {2} ", name, name.Substring(0, 1), name.Substring(found + 1));
            Console.ReadKey();
        }
    }
}
