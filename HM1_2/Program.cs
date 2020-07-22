using System;

namespace HW1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define 4 variables each with its own data type (int, double, bool, string). For 2 of them set the values at defining it, 
            //for other 2 define the variables without values and set the values later (do it in another code line). Print out all the values.
            int skaitlis = 1;
            double decimalis = 2.1;
            bool jaVaiNe;
            string teksts;

            jaVaiNe = false;
            teksts = " = ";

            Console.WriteLine(decimalis + teksts + skaitlis + " is " + jaVaiNe );
            Console.ReadKey();
        }
    }
}
