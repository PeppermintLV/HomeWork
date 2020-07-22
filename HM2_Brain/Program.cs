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



            int a = 100;
            string b = "10";

            string temp = a.ToString();
            a = int.Parse(b);
            b = temp;
            Console.WriteLine(a + " " + b);
            Console.ReadKey();
        }
    }
}
