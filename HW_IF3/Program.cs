using System;

namespace HW_IF3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vehicle driver has exceeded the allowed speed by x km/h (user inputs this). 
            //In case the speed exceeds by more than 10, then the penalty 15 eur, if by more than 20, then the penalty is 30, and if by more than 30, then the drivers license is lost.

            Console.WriteLine("Please write the speed difference:");
            string ExcessSpeed;
            ExcessSpeed = Console.ReadLine();
            int SpeedValue;
            SpeedValue = int.Parse(ExcessSpeed);

            if (SpeedValue > 10 && SpeedValue <= 20)
            {
                Console.WriteLine("Penalty for this is 15 eur!");
            }
            else if (SpeedValue > 20 && SpeedValue <= 30)
            {
                Console.WriteLine("Penalty for this is 30 eur!");
            }
            else
            {
                Console.WriteLine("Penalty for this is losing drivers license!");
            }


        }
    }
}
