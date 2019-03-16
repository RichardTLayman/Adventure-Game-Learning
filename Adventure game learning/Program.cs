// Learning from http://programmingisfun.com/learn/c-sharp-adventure-game/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Adventure_game_learning
{
    class Program
    {
        public static class Game
        {
            static int Scenarios = 3;
            //character name
            static string CharacterName = "John Doe";

            static string[] PartOne =
            {
                "Two doors stand before you. One is marked A, the other B. Which do you choose?",
                "Door A opens to a spout of flames.",
                "Door B sticks slightly as a chilly breeze rushes out for the opening",
                "Braving the elements, you open the door wider and step through",
                "Immeadiately you feel hot and sweaty as you rush through the fire corrider diving through the opening at the other side to safety",
                "Stepping carefully over the icy floor, you navigate to the end and almost make before slipping on teh ice and sliding through a small opening",
                "Recovering to your feet, you press on."
            };
            static string[] PartTwo =
            {
                "a",
                "b",
                "c",
                "d",
                "e",
                "f",
                "g"
            };
            static string[] PartThree =
            {
                "aa",
                "bb",
                "cc",
                "dd",
                "ee",
                "ff",
                "gg"
            };

            //print out game title and overview
            public static void StartGame()
            {
                GameTitle();
                NameCharacter();
                Choice();
                EndGame();
            }

            

            //ask player for a name, and save it
            static void NameCharacter()
            {
                Console.WriteLine("Please name your character:");
                CharacterName = Console.ReadLine();
                Console.WriteLine("   ----------------------");
                Console.WriteLine("| Welcome to the game " + CharacterName + ". |");
                Console.WriteLine("   ----------------------");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue:");               
            }
            static void Choice()
            {
               for (int section = 1; section <= Scenarios; section++)
                {
                    string input = "";

                    switch (section)
                    {
                        case 1:

                        Console.WriteLine(PartOne[0]);
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine("Enter your choice:");
                            input = Console.ReadLine();
                            input = input.ToLower();
                            Console.ResetColor();

                        if (input == "a")
                            {
                                Console.WriteLine(PartOne[1]);
                            }
                            else
                            {
                                Console.WriteLine(PartOne[2]);
                            }

                            Console.WriteLine(PartOne[3]);

                         if (input == "a")
                            {
                                Console.WriteLine(PartOne[4]);
                            }
                         else
                            {
                                Console.WriteLine(PartOne[5]);
                            }

                            Console.WriteLine(PartOne[6]);

                            break;

                        case 2:

                            Console.WriteLine(PartTwo[0]);
                            Console.ForegroundColor = ConsoleColor.Green;

                            Console.WriteLine("Enter your choice:");
                            input = Console.ReadLine();
                            input = input.ToLower();
                            Console.ResetColor();

                            if (input == "a")
                            {
                                Console.WriteLine(PartTwo[1]);
                            }
                            else
                            {
                                Console.WriteLine(PartTwo[2]);
                            }

                            Console.WriteLine(PartTwo[3]);

                            if (input == "a")
                            {
                                Console.WriteLine(PartTwo[4]);
                            }
                            else
                            {
                                Console.WriteLine(PartTwo[5]);
                            }

                            Console.WriteLine(PartTwo[6]);

                            break;

                        case 3:

                            Console.WriteLine(PartTwo[0]);
                            Console.ForegroundColor = ConsoleColor.Green;

                            Console.WriteLine("Enter your choice:");
                            input = Console.ReadLine();
                            input = input.ToLower();
                            Console.ResetColor();

                            if (input == "a")
                            {
                                Console.WriteLine(PartThree[1]);
                            }
                            else
                            {
                                Console.WriteLine(PartThree[2]);
                            }

                            Console.WriteLine(PartThree[3]);

                            if (input == "a")
                            {
                                Console.WriteLine(PartThree[4]);
                            }
                            else
                            {
                                Console.WriteLine(PartThree[5]);
                            }

                            Console.WriteLine(PartThree[6]);

                            break;

                        default:

                            break;
                    }

                    Console.WriteLine("Press enter to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            static void GameTitle()
            {
                string Title = @"
              {'' - ''}
                (o o)
              ,--`Y'--.
              ``:   ; ''
                / _ \
               ()' `()
              ";
                Console.Title = Title;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Title);
                Console.ResetColor();
                Console.WriteLine("Press enter to start");
                Console.ReadKey();
                Console.Clear();
            }
            private static void EndGame()
            {
                Console.WriteLine("Congratulations! You win!");
                Console.ReadKey();
            }
            
        }

        class Item
        {
        }

        static void Main(string[] args)
        {
            Game.StartGame();
            Console.ReadKey();
        }
    }
}
