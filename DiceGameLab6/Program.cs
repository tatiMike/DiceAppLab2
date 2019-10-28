using System;
using System.Text.RegularExpressions;

namespace DiceGameLab6
{
    
class Program
    {
       public static void Roll()
        {

        Start2:

            Console.WriteLine("\nPlease enter the number of sides for the first die.");
            String input1 = Console.ReadLine();
            int sides1;
            
                    if (!int.TryParse(input1, out sides1))
                    {
                        Console.WriteLine("That is not a number!");
                        goto Start2;
                    }
        Start3:                        
            Console.WriteLine("\nPlease enter the number of sides for the second die.");
            String input2 = Console.ReadLine();
            int sides2;
            
                    if (!int.TryParse(input2, out sides2))
                    {
                        Console.WriteLine("That is not a number!");
                        goto Start3;
                    }
            
                Random rnd = new Random();
                int dice1 = rnd.Next(1, sides1);
                int dice2 = rnd.Next(1, sides2);
                Console.WriteLine("\nRolling...");
                Console.WriteLine($"Roll 1: {dice1}");
                Console.WriteLine($"Roll 2: {dice2}");

                if (dice1 == 1 && dice2 == 1)
                    {
                        Console.WriteLine("Snake Eyes!");
                    }
                else if (dice1 + dice2 == 2 || dice1 + dice2 == 3 || dice1 + dice2 == 12)
                    {
                        Console.WriteLine("Craps!");
                    }
                else if (dice1 == 6 && dice2 == 6)
                    {
                        Console.WriteLine("Box Cars!");
                    }

            Console.WriteLine("\nWould you like to play again? Enter, Y or N.");
            string yesNo = Console.ReadLine();


            while (yesNo == "Y" || yesNo == "y")

                Roll();
            
            if (yesNo != "Y" && yesNo != "y")
            {
                Console.WriteLine("\nWould you like to quit the application?\n" +
                "Press \"Q\" to quit.");

                ConsoleKey response;
                response = Console.ReadKey(true).Key;

                if (response == ConsoleKey.Q)
                {
                    Console.WriteLine("\nGood bye!");
                    Environment.Exit(0);
                }
                else if (response != ConsoleKey.Q)
                {
                    goto Start2;
                }

            }


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice game!\n" +
            "\nPlease enter a name.");
            string name = Console.ReadLine();
            
            while (!Regex.IsMatch(name, @"^[a-zA-Z]\w+$"))
            {
                Console.WriteLine("\nPlease only use letters and no spaces.");
                name = Console.ReadLine();
            }
                        
            Start1:
            Console.WriteLine($"\nReady to roll the dice {name}? Enter, Y or N.");

            string inputYes = "y";

            inputYes = Console.ReadLine();

            if (inputYes == "Y" || inputYes == "y")

                Console.WriteLine("\nFirst, let's pick how many sides your dice will have!");

            else if (inputYes != "Y" && inputYes != "y")
            {
                Console.WriteLine("\nWould you like to quit the application?\n" +
                "Press \"Q\" to quit. Press any key to restart.");

                ConsoleKey response;
                response = Console.ReadKey(true).Key;

                if (response == ConsoleKey.Q)
                {
                    Console.WriteLine("\nGood bye!");
                    return;
                }
                else if (response != ConsoleKey.Q)
                {
                    goto Start1;
                }
                
            }

            Roll();




        }
    }
}
