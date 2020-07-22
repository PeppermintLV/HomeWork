using System;

namespace CW5_6
{
    //Create an enum which has the values of weekdays. Define new variable with the type of newly created enum and assign "Friday". 
    //Then switch the enum variable and print a different message for each day.

    enum WeekEnum
    {
        Mon,
        Tue,
        Wed,
        Thu,
        Fri,
        Sat,
        Sun

    }

    class Program
    {
        static void Main(string[] args)
        {
            WeekEnum day = WeekEnum.Fri;


            switch (day)
            {
                case WeekEnum.Mon:
                    Console.WriteLine("Go!");
                    break;
                case WeekEnum.Tue:
                    Console.WriteLine("Try your best!");

                    break;
                case WeekEnum.Wed:
                    Console.WriteLine("Little Saturday night!");

                    break;
                case WeekEnum.Thu:
                    Console.WriteLine("Still going strong!");

                    break;
                case WeekEnum.Fri:
                    Console.WriteLine("TGIF!");

                    break;
                case WeekEnum.Sat:
                    Console.WriteLine("Sleep all day, sleep all night!");

                    break;
                case WeekEnum.Sun:
                    Console.WriteLine("Ready.. Set..");

                    break;
                default:
                    break;
            }



        }
    }
}
