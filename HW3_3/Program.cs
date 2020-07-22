using System;

namespace HW3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //At Christmas market you have bought yourselft a Christmas tree (spruce). The tree is described after 3 parameters – height, branch width and type (traditional tree or silver tree). 
            //Tree parameters can be defined in the program as programmer variables or they can be asked from the user. 
            //Depending on the height, width, type the tree must be correctly placed in the house. If the tree is silver type, it can only be placed in the fireplace hall.

            //Height(cm) Branch width(cm) Room
            //50 <= x < 100 100 <= y < 150 Living room nr.1
            //100 <= x < 150 150 <= y < 200 Living room nr.2
            //150 <= x <= 300 200 <= y <= 300 Fireplace hall

            //Im not quite sure what to do with a tree that is not proportional? What if the tree is 200 cm long but 100 cm wide? Are all trees assumed to be proportional? 
            
            Console.WriteLine("Please write selected trees type:");
            string type;
            type = Console.ReadLine();                                

            if (type == "silver" || type == "Silver")
            {
                Console.WriteLine("This tree can only be placed in the fireplace hall!");
            }

            else
            {
                Console.WriteLine("Please write selected trees height:");
                string tempH;
                tempH = Console.ReadLine();
                int height = int.Parse(tempH);
                Console.WriteLine("Please write selected trees width!");
                string tempW;
                tempW = Console.ReadLine();
                int width = int.Parse(tempW);


                if (height >= 50 && height <100 && width >= 100 && width < 150)
                {
                    Console.WriteLine("This tree can only be placed in the Living room 1.!");
                }

                else if (height >= 100 && height < 150 && width >= 150 && width < 200)
                {
                    Console.WriteLine("This tree can only be placed in the Living room 2.!");
                }

                else if (height >= 150 && height < 300 && width >= 200 && width < 300)
                {
                    Console.WriteLine("This tree can only be placed in the fireplace hall!");
                }
            }

            





        }

    }
}
