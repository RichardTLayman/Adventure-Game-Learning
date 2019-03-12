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
        static void Main(string[] args)
        {
            string CharacterName = "John Doe";

            Console.WriteLine("My Adventure Game.");
            Console.ReadKey();

            Console.WriteLine("Please name your character:");
            CharacterName = Console.ReadLine();
            Console.WriteLine("Welcome to the game " + CharacterName + ".");

            
        }
    }
}
