using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace hello_dungeon
{
    struct Player
    {
        public float playerHealth;
        public float playerMana;
        public float playerGold;
        public string playerRole;
        public int playerPotion;

        public Player(
           float playerHealth,
           float playerMana,
           float playerGold,
           string playerRole,
           int playerPotion)
        {
            this.playerHealth = playerHealth;
            this.playerMana = playerMana;
            this.playerGold = playerGold;
            this.playerRole = playerRole;
            this.playerPotion = playerPotion;
        }
    }


    internal class Game
    {
        //establshing gameover, and an empty struct
            Player player1;
            bool _gameover;
        void Start()
        {
                //giving struct input data
                player1 = new Player(playerHealth: 100, playerMana: 100, playerGold: 100, playerRole: "", playerPotion: 1);
                
        }






        /*while gameover is false, game keeps running until health is zero
        or until the player reaches end of code/game
         */

        public void Run()
        {
            Start();
            while (!_gameover)
            {
                Update();

            }
            End();
        }
        
            
            
            void Update()
            {

            if (player1.playerHealth <= 0)
            {
                _gameover = true;
            }



                int input = GetInput3("Are you a ", "Warrior", " Fighter", " Wizard");


                if (input == 1)
                {
                    player1.playerRole = "Warrior";
                }
                else if (input == 2)
                {
                    player1.playerRole = "Fighter";
                }
                else if (input == 3)
                {
                    player1.playerRole = "Wizard";
                }
                else
                {
                    Console.WriteLine("Invalid Selection");
                }

                Console.WriteLine();

                PrintPlayerStats(player1);

                Console.WriteLine();

                // function GetInput2 used, only takes two options/strings after the initial question


                input = GetInput2("You wake up in a dark cave, out of the shadows a car salesman appears regarding you cars extended warranty. " +
                    "Do you pass on or conversate?", "Pass on", "Conversate");
                if (input == 1)
                {
                    Console.WriteLine("Care salesman: Well fairwell then!");
                }
                else if (input == 2)
                {
                    Console.WriteLine("Your car is so old there are no warranties, goodbye!");
                }
                Console.WriteLine();


                input = GetInput2("You step onto an algae covered rock and slip into a hole, do you use your special ability or go to sleep?",
                    "1: Sleep", "2: Use ability");


                Console.WriteLine();


                if (input == 1)
                {
                    Console.WriteLine("You goto sleep, upon awakening the hole is suddenly flooded enough for you to escape.");
                    if (player1.playerRole == "Wizard")
                    {
                        Console.WriteLine();
                        Console.WriteLine("You cast a short lasting fire spell, drying yourself off.");
                        SubMana();
                    }

                }
                else if (input == 2 && player1.playerRole == "Warrior")
                {

                    Console.WriteLine("You charge up and leap out of the deep hole in a single bound.");
                    SubMana();
                }
                else if (input == 2 && player1.playerRole == "Wizard")
                {

                    Console.WriteLine("You cast a levatation spell and float out gracefully.");
                    SubMana();
                }
                else if (input == 2 && player1.playerRole == "Fighter")
                {

                    Console.WriteLine("You charge your fists and punch your way out the hole without a scratch.");
                    SubMana();
                }



                input = GetInput2("A coyote appears from the shadows, do you:", "Flee", "Fight");

                // determine if the player wants to flee or fight, conditions based off of  playerRole 

                if (input == 1 && player1.playerRole == "Warrior")
                {
                    Console.WriteLine("You jump over the coyote, scaring he/she/they/them out of the cave.");
                }

                else if (input == 1 && player1.playerRole == "Wizard")
                {
                    Console.WriteLine("You sprint away from the coyote, it dashes towards you and slips into the hole. You walk on.");
                }

                else if (input == 1 && player1.playerRole == "Fighter")
                {
                    Console.WriteLine("The coyote charges, you sidestep and it knocks itself out on the cave wall.");

                }
                else if (input == 2 && player1.playerRole == "Warrior")

                {
                    Console.WriteLine("You curb stomp the coyote into a puddle of mush.");
                    SubMana();
                }

                else if (input == 2 && player1.playerRole == "Wizard")
                {
                    Console.WriteLine("You cast an ice spell, freezing the coyote solid.");
                    SubMana();
                }

                else if (input == 2 && player1.playerRole == "Fighter")
                {
                    Console.WriteLine("You two piece the coyote caving in his dome.");
                    SubMana();
                }

                //GetInput function called to decide 
                //player takes damage, player stats are printed to player

                input = GetInput2("A Shaq sized Ogre smacks you with the car salesman's body, do you ",
                     "take a health potion", "save the potion for later");
                SubHealth(2);

                if (input == 1)
                {
                    Potion();
                }
                else if (input == 2 || input != 1)
                {
                    Console.WriteLine("alright tough guy");
                }

            _gameover = true;
            }
        //end
        void End()
        {
            Console.WriteLine("Game Over");
            Console.ReadKey();
        }

        // print player stats function
        static void PrintPlayerStats(Player player)
        {
            Console.WriteLine(player.playerRole + " Health: " + player.playerHealth);
            Console.WriteLine(player.playerRole + " Mana:   " + player.playerMana);
            Console.WriteLine(player.playerRole + " Gold:   " + player.playerGold);
            Console.WriteLine("Role Selected:   " + player.playerRole);
            Console.WriteLine(player.playerRole + " Health Potions:   " + player.playerPotion);
            Console.WriteLine();
        }
                //SubMana function for special ability use, prints playerstats afterwards
                int SubMana()
                
                {
                  
                    Console.WriteLine();
                    player1.playerMana -= 25;
                    PrintPlayerStats(player1);
                    Console.WriteLine();
                    return 0;
                }
            
                int SubHealth(int i)
                {
                 player1.playerHealth -= ( i * 25);
                PrintPlayerStats(player1);
                return 0;
                }
                    
                

            //work in progress mana/health potion
            int Potion()
            {
                if (player1.playerHealth <= 50)
                {
                    Console.WriteLine();
                    player1.playerPotion -= 1;
                    player1.playerHealth += 50;
                    PrintPlayerStats(player1);
                }
                else
                {
                    Console.WriteLine("Your health isn't low enough!");

                }
                return 0;
            }




            // GetInput2 
            int GetInput2(string description, string option1, string option2)
            {
                string input = "";
                int inputRecieved = 0;
                while (inputRecieved != 1 && inputRecieved != 2)
                {
                    Console.WriteLine(description);
                    Console.WriteLine("1. " + option1);
                    Console.WriteLine("2. " + option2);
                    Console.WriteLine(">. ");

                    input = Console.ReadLine();

                    if (input == "1" || input == option1)
                    {
                        inputRecieved = 1;
                    }
                    else if (input == "2" || input == option2)
                    {
                        inputRecieved = 2;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input goober");
                    }
                }
                Console.Clear();
                return inputRecieved;


            }






            int GetInput3(string description, string option1, string option2, string option3)
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
                    Console.WriteLine(">.");

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




                

     

