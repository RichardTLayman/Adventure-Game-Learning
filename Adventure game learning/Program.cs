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

            static List<string> Inventory = new List<string>();

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
                "Brushing off your clothes, you notice two items before you. A sword, and an Axe. Which do you take?",
                "Grabbing the sword, the Axe vanishes and a shadow emerges from the floor.",
                "Grabbing the Axe, the sword vanishes and a shadow emerges from teh floor.",
                "The shadow snarls at you and lunges forward.",
                "Parrying the attack with your sword, you cleave the monster in two. Something metallic falls to teh ground off its dead body.",
                "It charges with dark claws as you spin around and strike heavily into its chest with your axe. As it gurgles into death, you notice something metallic.",
                "You reach down and grab a key that fell from the shadow."
            };
            static string[] PartThree =
            {
                "A locked door now stands before you. A keyhole and and a handprint are on it. Which do you use?",
                "Placing teh key you found inside the keyhole, you give it a turn and unsurprising it opens, but the key vanishes.",
                "You place your palm on teh panel and it glows with a pale blue light, then the door opens",
                "You pass through the enterway. Gold and treasure fills the room as far as you can see.",
                "You pocket some spare coins as you notice a golden chest. Alas it is locked",
                "A large golden chest snags your attention and you try teh key on it. It opens revealing a magic lamp. You take it.",
                "With plenty of gold in your pockets, you turn to leave and head home."
            };

            //print out game title and overview
            public static void StartGame()
            {
                GameTitle();
                NameCharacter();
                Item free = new Item();
                Inventory.Add(Convert.ToString(free));
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
                                Inventory.Add("Sword");
                            }
                            else
                            {
                                Console.WriteLine(PartTwo[2]);
                                Inventory.Add("Axe");
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
                            Inventory.Add("Key");

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
                                Inventory.Add("Magic Lamp");
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

                Console.WriteLine(CharacterName + ", you found some items in your journy:");

                foreach (string item in Inventory)
                    {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(item);
                    Console.ResetColor();
                    }
                Console.ReadKey();
            }
            
        }

        public class Item
        {
            public string Name = "small stone";
            public string Description = "Unimpressive object.";

            string[] Items = { "shoe", "can", "pair of chopsticks" };
            string[] Descriptions = { "Size 10 sneaker", "Empty root beer can", "Pink plastic chopsticks" };

            // constructor
            public Item()
            {
                Random randomNumber = new Random();
                int number;

                number = randomNumber.Next(Items.Length);

                Name = Items[number];
                Description = Descriptions[number];

                Console.WriteLine("You found a " + Name + " (" + Description + ").");
            }

        }

        static void Main(string[] args)
        {
            Game.StartGame();
            Console.ReadKey();
        }
    }
}
