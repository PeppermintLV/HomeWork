using System;

namespace HM2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define 4 string variables. Use 3 different string handling ways, in order to combine them and print them out.
            //1.way = use +
            //2.way = $" {str1} {str2} "
            //3.way = use method String.Format("Some text {0} un {1}", str1, str2)

            string string1 = "Mans ";
            string string2 = "Vards ";
            string string3 = "ir ";
            string string4 = "Darta ";

            Console.WriteLine(string1 + string2 + string3 + string4);
            Console.WriteLine($"{string1}{string2}{string3}{string4}");
            Console.WriteLine("{0}{1}{2}{3}", string1, string2, string3, string4);
            Console.ReadKey();
        }
    }
}
