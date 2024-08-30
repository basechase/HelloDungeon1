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
            int input = GetInput("Are you a ", "Warrior", " Fighter", " Wizard");


            if (input == 1)
            {
                playerRole = "Warrior";
            }
            else if (input == 2)
            {
                playerRole = "Fighter";
            }
            else
            {
                playerRole = "Wizard";
            }















            Console.WriteLine("Player role: " + playerRole + " selected" + playerName);


            Console.WriteLine();

            Console.WriteLine();

            input = GetInput("You wake up in a dark cave, out of the shadows a car salesman appears regarding you cars extended warranty. " +
                "Do you pass on or conversate?", " Pass on", " Talk", ">");
            if (input == 1)
            {
                Console.WriteLine("Care salesman: Well fairwell then!");
            }
            else if (input == 2)
            {
                Console.WriteLine("Your car is so old there are no warranties, goodbye!");
            }
            Console.WriteLine();






            input = GetInput("You step onto an algae covered rock and slip into a hole, do you use your special ability or go to sleep?",
                "1: Sleep", "2: Use ability", ">");






            Console.WriteLine();


            if (input == 1)
            {
                Console.WriteLine("You goto sleep, upon awakening the hole is suddenly flooded enough for you to escape.");
                if (playerRole == "Wizard")
                {
                    Console.WriteLine();
                    Console.WriteLine("You cast a short lasting fire spell, drying yourself off.");
                }

            }
            else if (input == 2 && playerRole == "Warrior")
            {

                Console.WriteLine("You charge up and leap out of the deep hole in a single bound.");
            }
            else if (input == 2 && playerRole == "Wizard")
            {

                Console.WriteLine("You cast a levatation spell and float out gracefully.");
            }
            else if (input == 2 && playerRole == "Fighter")
            {

                Console.WriteLine("You charge your fists and punch your way out the hole without a scratch.");

            }



            Console.WriteLine();
            input = GetInput("You notice a skeleton approaching you, do you flee or fight?", 
                "1: Flee", "2: Fight", ">");
            Console.WriteLine();
            // you stopped here, change flightorflee to input
            string fightOrFlee = "";
            while (fightOrFlee != "1" && fightOrFlee != "2")
            {
                fightOrFlee = Console.ReadLine();
                if (fightOrFlee == "1" && playerRole == "Wizard")
                {

                    Console.WriteLine("You teleport past the skeleton, he gets startled, falls over and dies.");
                }
                else if (fightOrFlee == "1" && playerRole == "Fighter")
                {
                    Console.WriteLine("You swiftly sprint, creating a small gust of wind that knocks the skeleton" +
                        "into a pile of bone dust.");
                }
                else if (fightOrFlee == "1" && playerRole == "Warrior")
                {
                    Console.WriteLine("You sidestep past the skeleton, your souless eyes cause him to tremble," +
                        "breaking all of his bones.");
                }

                if (fightOrFlee == "2" && playerRole == "Wizard")
                {
                    Console.WriteLine("You cast an ice spell, creating a skeleton popsicle.");
                }
                else if (fightOrFlee == "2" && playerRole == "Fighter")
                {
                    Console.WriteLine("You two piece the skeleton, breaking his ego and dome.");
                }
                else if (fightOrFlee == "2" && playerRole == "Warrior")
                {
                    Console.WriteLine("You grab the skeleton by the neck and RKO him into the hole.");
                }
            }






        }


        int GetInput(string description, string option1, string option2, string option3)
        {
            string input = "";
            int inputRecieved = 0;
            // Input Loop
            while (inputRecieved != 1 && inputRecieved != 2 && inputRecieved != 3)
            {
                //Print Options
                Console.WriteLine(description);
                Console.WriteLine("1. " + option1);
                Console.WriteLine("2. " + option2);
                Console.WriteLine("3. " + option3);

                //Get input from player

                input = Console.ReadLine();

                //IF player slected first option
                if (input == "1" || input == option1)
                {
                    inputRecieved = 1;
                }
                //otherwise if second option selected
                else if (input == "2" || input == option2)
                {
                    //set input recieved to the second option
                    inputRecieved = 2;

                }
                else if (input == "3" || input == option3)
                {
                    //set input rcvd to the third option
                    inputRecieved = 3;
                }
                //if neither true
                else
                {
                    Console.WriteLine("Invalid Input");
                    Console.ReadKey();
                }
            }

            Console.Clear();
            return inputRecieved;
        }
    }
}




                

     

