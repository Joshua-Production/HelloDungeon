using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    internal class Game
    {
        public async void Run()
        {
            string playerName = "Boblius";
            float playerHealth = 10.0f;
            float playerMana = 5.0f;
            int playerGold = 3;
            float playerStamina = 100;
            int playerXp = 0;
            int playerHealthPotion = 5;
            int playerManaPotion = 5;
            int playerFood = 3;
            string dooroption1 = "Door1";
            string dooroption2 = "Door2";
            string playerRole1 = "Warrior";
            string playerRole2 = "Wizard";

            Console.WriteLine("Hello , " + playerName);
            Console.WriteLine();
            Console.WriteLine("Welcome to my dungeon!");
            Console.WriteLine();
            Console.WriteLine("Health: " + playerHealth);
            Console.WriteLine("Mana; " + playerMana);
            Console.WriteLine("Stamina; " + playerStamina);
            Console.WriteLine("Xp; " + playerXp);
            Console.WriteLine("Gold; " + playerGold);
            Console.WriteLine("HPpot; " + playerHealthPotion);
            Console.WriteLine("MPpot; " + playerManaPotion);
            Console.WriteLine("Food; " + playerFood);
            int input = GetInput("Are you a warrior or a wizard?", "Warrior", "Wizard");


            







        }


        int GetInput(string description, string option1, string option2)
        {
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

                // If player selected the first option

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
            Console.Clear();
            return inputRecieved;


        }







    }
}
        

