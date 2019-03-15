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
            //character name
            static string CharacterName = "John Doe";

            //print out game title and overview
            public static void StartGame()
            {
                GameTitle();
                NameCharacter();
                Choice();
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
                string input = "";
                Console.WriteLine(CharacterName + ", Two doors appear before you. The first glows red and screams with flames. The second is frozen and sparkles with ice.");
                Console.WriteLine("Which path do you choose? Fire or Ice?");
                input = Console.ReadLine();
                input = input.ToUpper();

                if (input == "FIRE")
                { 
                    Console.WriteLine("Flames burn around you as you quickly navigate the path of fire. You arrive at other end a litle singed, but alive.");
                }
                else
                {
                    Console.WriteLine("Shaking from the cold, you slowly cross the icy floor. You arrive at the other end with a few icicles forming on your brow, but otherwise safe.");
                }

                Console.WriteLine();
                Console.WriteLine("With the first trial complete, you smile and walk toword the next.");
            }
            static void GameTitle()
            {
                string Title = @"Your title here";
                Console.Title = Title;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Title);
                Console.ResetColor();
                Console.WriteLine("Press enter to start");
                Console.ReadKey();
                Console.Clear();
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
