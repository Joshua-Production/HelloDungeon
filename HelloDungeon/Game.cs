using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    internal class Game
    {
        struct Player
        {
            public string Name;
            public float Health;
            public float Mana;
            public int Stamina;
            public int Gold;
            public float Xp;
            public int HealthPotion;
            public int ManaPotion;
            public int Food;
            public string Role;
            public string PlayerInput;
            // <summary>
            // players constructor 
            /// </summary>
            /// <param name="Name"></param>
            /// <param name="Health"></param>
            /// <param name="Mana"></param>
            /// <param name="Stamina"></param>
            /// <param name="Gold"></param>
            /// <param name="Xp"></param>
            /// <param name="HealthPotion"></param>
            /// <param name="ManaPotion"></param>
            /// <param name="Food"></param>
            /// <param name="PlayerRole"></param>
            /// <param name="PlayerInput"></param>
            public Player(
                string Name,
                float Health,
                float Mana,
                int Stamina,
                int Gold,
                float Xp,
                int HealthPotion,
                int ManaPotion,
                int Food,
                string Role,
                string PlayerInput)

            {  
                this.Name = Name;
                this.Health = Health;
                this.Mana = Mana;
                this.Stamina = Stamina;
                this.Gold = Gold;
                this.Xp = Xp;
                this.HealthPotion = HealthPotion;
                this.ManaPotion = ManaPotion;
                this.Food = Food;
                this.Role = Role;
                this.PlayerInput = PlayerInput;
            }
        }

        //Summary means quotes

        /// <summary>
        /// 
        /// </summary> 
        /// <param name="description">The names of the options</param>           
        /// <param name="option1">The 1st option</param>
        /// <param name="option2">The 2nd option</param>
        /// <returns></returns>
        int GetInput(string description, string option1, string option2)
        {
            // Players Typed input
            string input = "";
            int inputRecieved = 0;

            // Input loop
            while (inputRecieved != 1 && inputRecieved != 2)
            {
                // Print options
                Console.WriteLine(description);
                Console.WriteLine("1. " + option1);
                Console.WriteLine("2. " + option2);
                Console.Write("> ");
                // Get input from player
                input = Console.ReadLine();

                // If player selected the first option
                if (input == "1" || input == option1)
                {
                    // Set inputRecieved to be the first option
                    inputRecieved = 1;
                }
                // Otherwise if the player selected the second option
                else if (input == "2" || input == option2)
                {
                    // Set inputRecieved to be the second option
                    inputRecieved = 2;
                }
                // If neither are true
                else
                {
                    // Display error message
                    Console.WriteLine("Invalid Input");
                    Console.ReadKey();
                }
            }
           
            // after loop, clear console;
            Console.Clear();
            //return inputReceived integer;
            return inputRecieved;
        }
    
         
        //Mothod declared 
        public void Run()
        {  // type name = value
            Player player1 = new Player(" Jim", Health: 20f, Mana: 50f, Stamina: 100, Gold: 5, Xp: 0f, HealthPotion: 5, ManaPotion: 5, Food: 3, Role: "", PlayerInput: "");

            Console.WriteLine(" You find yourself inside of what seems to be a cave with no exit or entrance ");
            Console.WriteLine("");
            Console.WriteLine(" Hello Jim"); 
            Console.WriteLine(" I see that you found my dungeon... Now i will give you a choice would you like to be a Warrior or a Wizard? ");
            
            int input = 0;

           
            //Player Choices

            input = GetInput(" Warrior = 1 | Wizzard = 2 ", " Warrior ", " Wizzard ");
            if (input == 1)
            {
                player1.Role = "Warrior";
            }
            else if (input == 2)
            {
                player1.Role = "Wizard";
            }

            Console.WriteLine(" Player role: " + player1.Role);
            Console.WriteLine("");

            Console.WriteLine(" So, you chose " + player1.Role);
            Console.WriteLine("");
            Console.WriteLine(" These are your stats.");
            Console.WriteLine("");
         
            





            
            
            //prints the players stats
            PrintPlayerStats(player1);
            Console.WriteLine(" Press Any Key To Continue ");
            Console.WriteLine("");
            Console.ReadKey();

            Console.Clear();

            input = 0;

            GetInput(" Two Doors appear infront of you These doors may look the same but the path they bring you on is for you to decide ", "Door 1", "Door 2");
           
            



        }  

        /// <summary>
        /// Function for printing the player's stats
        /// </summary>
        /// <param name="player">The instance of a player whose stats this function is printing</param>
        static void PrintPlayerStats(Player player)
        {
            Console.WriteLine(player.Name);  
            Console.WriteLine( " Health:" +          player.Health);
            Console.WriteLine( " Mana:  " +          player.Mana);
            Console.WriteLine( " Gold:  " +          player.Gold);
            Console.WriteLine( " Xp:    " +          player.Xp);
            Console.WriteLine( " HealthPotions:  " + player.HealthPotion);
            Console.WriteLine( " ManaPotion:  " +    player.ManaPotion);
            Console.WriteLine( " Food:  " +          player.Food);
            
        }
         

  
    }
}
        

