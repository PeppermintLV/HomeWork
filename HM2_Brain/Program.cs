using System;

namespace HM2_Brain
{
    class Program
    {
        static void Main(string[] args)
        {
            //For those who would like to learn to think outside the box:
            //Create a program and define 2 variables – a, b.Data type of your choice(e.g. - string or int).
            //You can create these variables on your own or ask from user to fill from Console.
            //Main task – figure out how to change both values in between themselves. 
            //Then print out the values a & b.You need to print out exactly a &b, but the values have to be switched.

            int skaitlis= 100;
            string teksts = "10";

            string temp = skaitlis.ToString();
            skaitlis = int.Parse(teksts);
            teksts = temp;
            Console.WriteLine(skaitlis +" "+ teksts);
            Console.ReadKey();
        }
    }
}
