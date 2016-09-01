using System;
//using Lab5_RollDice;

namespace Roll_dice
{
    class Program
    {
        string option;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Casino! Roll the dice ?(y/n");
          string  option= Console.ReadLine();

            while (option == "y") 
            {
                int roll1 = int.Parse(Console.ReadLine());
                string i1 = Class1.Dice_Roll(roll1);

                Console.WriteLine(i1);
                Console.WriteLine("Roll again?(y/n)");
               option= Console.ReadLine();
            } 





        }
    }
}
