using System;

namespace HM3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a console application and ask user for two values x, y. Program has to sum these 2 values (use int.Parse, or Convert.ToInt32). 
            //Before the sum make x is between 0 and 20. Value y must be between 30 and 50. If a number is not entered in the given range then show an error message. 
            //Therefore if any of the numbers are incorrect then show an error message and only then when BOTH numbers are correct, show sum.

            int skaitlis1;
            int skaitlis2;

            Console.WriteLine("Ievadet pirmo skaitli.");
            string temp = Console.ReadLine();
            skaitlis1 = int.Parse(temp);

            if (skaitlis1 < 0 || skaitlis1 > 20)
            {
                Console.WriteLine("Pirmais skaitli ievadits nepareizi.");
            }
            else
            {
                Console.WriteLine("Ievadet otro skaitli.");
                temp = Console.ReadLine();
                skaitlis2 = int.Parse(temp);

                if (skaitlis2 < 30 || skaitlis2 > 50)
                {
                    Console.WriteLine("Otrais skaitli ievadits nepareizi."); 
                }
                else
                {
                    Console.WriteLine("Skaitlu summa ir " + (skaitlis1 + skaitlis2));
                }             
            }

          
        }
    }
}
