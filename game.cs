using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
            string playerRole = "Fighter";

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
            Console.WriteLine("Are you a Warrior, Fighter, or Wizard?");




            string input = "";

            while (input != "1" && input != "2" && input != "3")
            {
                Console.Write("(1 | 2 | 3) > ");
                input = Console.ReadLine();


                if (input == "1")
                {

                    playerRole = "Warrior";
                }
                else if (input == "2")
                {
                    playerRole = "Fighter";
                }
                else if (input == "3")
                {
                    playerRole = "Wizard";
                }

                Console.WriteLine("Player role: " + playerRole + " selected");
            }

            Console.WriteLine();
            Console.WriteLine("You wake up in a dark cave, out of the shadows a car salesman appears regarding you cars extended" +
                "warranty. Do you pass on or conversate? 1: Pass on | 2: Talk ");
            Console.WriteLine();
            string talk = "";
            while (talk != "1" && talk != "2")
            {
                talk = Console.ReadLine();

                if (talk == "1")
                {
                    Console.WriteLine("Care salesman: Well fairwell then!");
                }
                else if (talk == "2")
                {
                    Console.WriteLine("Your car is so old there are no warranties, goodbye!");
                }
                Console.WriteLine();
            }


            Console.WriteLine("You step onto an algae covered rock and slip into a hole, do you use your special ability or go to sleep?" +
                "1: Sleep | 2: Use ability");

            
            
            string escapeMethod = "";
            string useAbility = "";

            Console.WriteLine();
            while (useAbility != "1" && useAbility != "2")
            {
                useAbility = Console.ReadLine();
                if (useAbility == "1")
                {
                    Console.WriteLine("You goto sleep, upon awakening the hole is suddenly flooded enough for you to escape.");

                }
                else if (useAbility == "2" && playerRole == "Warrior")
                {
                    
                    Console.WriteLine("You charge up and leap out of the deep hole in a single bound.");
                }
                else if (useAbility == "2" && playerRole == "Wizard")
                {
                    
                    Console.WriteLine("You cast a levatation spell and float out gracefully.");
                }
                else if (useAbility == "2" && playerRole == "Fighter" )
                {
                    
                    Console.WriteLine("You charge your fists and punch your way out the hole without a scratch.");
                }

                Console.WriteLine();
                if (playerRole == "Wizard" && useAbility =="1")
                {
                    
                    Console.WriteLine("You cast a short lasting fire spell, drying yourself off.");
                }

                Console.WriteLine();
                Console.WriteLine("You notice a skeleton approaching you, do you flee or fight?" +
                    "1: Flee | 2: Fight");
                Console.WriteLine();

                string fightOrFlee = "";
                while (fightOrFlee !="1" && fightOrFlee !="2")
                {
                    fightOrFlee = Console.ReadLine();
                    if (fightOrFlee =="1" && playerRole=="Wizard")
                    {

                        Console.WriteLine("You teleport past the skeleton, he gets startled, falls over and dies.");
                    }
                    else if (fightOrFlee == "1" && playerRole == "Fighter")
                    {
                        Console.WriteLine("You swiftly sprint, creating a small gust of wind that knocks the skeleton" +
                            "into a pile of bone dust.");
                    }
                    else if (fightOrFlee =="1" && playerRole == "Warrior")
                    {
                        Console.WriteLine("You sidestep past the skeleton, your souless eyes cause him to tremble," +
                            "breaking all of his bones.");
                    }
                    
                    if (fightOrFlee == "2" && playerRole=="Wizard")
                    {
                        Console.WriteLine("You cast an ice spell, creating a skeleton popsicle.");
                    }
                    else if (fightOrFlee =="2" && playerRole=="Fighter")
                    {
                        Console.WriteLine("You two piece the skeleton, breaking his ego and dome.");
                    }
                    else if (fightOrFlee=="2" && playerRole=="Warrior")
                    {
                        Console.WriteLine("You grab the skeleton by the neck and RKO him into the hole.");
                    }
                }





            }
        }

    }

}



                

     

