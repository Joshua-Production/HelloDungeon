using System;
using System.Collections.Generic;
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
            string playerRole = "Warrior" ;


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
            Console.WriteLine("Food; " +  playerFood);

            Console.WriteLine("Are you a Warrior or a Wizard?");


            string input = "";



            while (input != "1" && input != "2")
            {
                Console.Write("1 | 2 > ");
                input = Console.ReadLine();

                if (input == "1")
                {
                    playerRole = "Warrior";
                }
                else if (input == "2")
                {
                    playerRole = "Wizard";
                }
            }
            Console.WriteLine("Player role: " + playerRole);


            Console.WriteLine("So, you chose " + playerRole + "Now you have a second decision");



            Console.WriteLine("You find yourself in await Generic dungeon " +
            "with two doors. Which door do you chose?");


            Console.WriteLine();
            Console.WriteLine("Door 1 or Door 2");
            input = Console.ReadLine();

            if (input == "1")
            {

                Console.WriteLine("Looks like you chose " + dooroption1);
            }

            if (input == "2")
            {

                Console.WriteLine("Looks like you chose " + dooroption2);
            }


        }
    }
}
