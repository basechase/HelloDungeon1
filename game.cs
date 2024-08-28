using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace hello_dungeon
{
    internal class Game
    {
            public void Run()
            {
                string playerName = "BobLee";
                float playerHealth = 10.0f;
                float playerMana = 5.0f;
                int playerGold = 3;
                bool playerTorch = true;
            
                Console.WriteLine("Hello " + playerName);
                Console.WriteLine();
                Console.WriteLine("Welcome to my dungeon");
                Console.WriteLine();
                Console.WriteLine("Health " + playerHealth);
                Console.WriteLine();
                Console.WriteLine("Mana " + playerMana);
                Console.WriteLine();
                Console.WriteLine("Gold " + playerGold);
                Console.WriteLine();
                Console.WriteLine("You find yourself in a generic dungeon with " +
                "two doors. Which door do you choose?");
                Console.WriteLine();
            Console.WriteLine();
                Console.WriteLine();

        }
    }
}
