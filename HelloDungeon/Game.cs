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
            string playerItem1 = "Sword";
            string itemHp = "Durability"; 
  
           
            
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
            Console.WriteLine("Item;" + playerItem1);
            Console.WriteLine("You find yourself in await Generic dungeon " +
                "with two doors. Which door do you chose?");
            
        }
    }
}
