﻿using System;
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
            string playerRole1 = "Warrior" ;
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
            Console.WriteLine("Food; " +  playerFood);

            Console.WriteLine("Are you a Warrior or a Wizard?");


            string input = "";



            while (input != "1" && input != "2")
            {
                Console.Write("1 | 2 > ");
                input = Console.ReadLine();

                if (input == "1")
                {
                    playerRole1 = "Warrior";
                }
                else if (input == "2")
                {
                    playerRole2 = "Wizard";
                }
            }
            Console.WriteLine("Player role: " + playerRole1);


            Console.WriteLine("So, you chose " + playerRole2 + " Now you have a second decision");



            Console.WriteLine("You find yourself in a dungeon " +
            "with two doors. Which door do you chose?");


            Console.WriteLine();
            Console.WriteLine("Door 1 or Door 2");
            input = Console.ReadLine();

            if (input == "1")
            {

                Console.WriteLine("Looks like you chose " + dooroption1);
                Console.WriteLine("As you enter Door 1 you see a giant goblin ," +
                    " Will you Flee or Fight?");
                Console.WriteLine();
                Console.WriteLine(" Flee or Fight ");
                input = Console.ReadLine();
                

                if (input == "Flee")
                {
                    Console.WriteLine(" As you turn to Flee the door slams shut trapping you in the room forcing you to fight. " +
                        " You turn back around to see that the goblin is about to strike you. You atempt to block but the goblin hits you! " +
                       " Cutting your HP from " +
                       playerHealth + " To " + playerHealth / 2f);
                    Console.Write(" Press any key to continue ");
                    Console.ReadKey();


                    Console.Clear();
                    Console.WriteLine(" As you get back up you dash at the goblin how will you attack? " +
                        "A double slash or A Strong Single Slash");
                   
                    Console.WriteLine(" (Light) Double Slash or (Strong) Single Slash");
                    input = Console.ReadLine();
                    if (input == "Light")
                    {
                        Console.WriteLine(" You Slash twice and killed the goblin");
                        Console.WriteLine();

                        Console.WriteLine(" YOU WIN");
                    }

                    if (input == "Strong")
                    {
                        Console.WriteLine("You chose to finish this fight in one Strong Slash" + 
                            "So you slash spliting the goblin in 2");

                        Console.WriteLine();
                        Console.WriteLine("YOU WIN");


                    }

                }

                {
                    if (input == "Fight ");

                    Console.WriteLine("Ah you chose to fight I will now bless you with a hidden buff for only True Worriors " + 
                        " You scream out activating the buff (BERSERK MODE) 100% damage increase ");
                    Console.WriteLine();
                    Console.WriteLine("You dash at the goblin taking it down in one shot");
                    Console.WriteLine("YOU WIN");
                }
            }

            if (input == "2")
            {

                Console.WriteLine("Looks like you chose " + dooroption2);
                Console.WriteLine("As you enter Door 2 you see a Mage who on sight starts to power up a powerful looking spell");

                Console.WriteLine("Looks like that leaves you wiht two options Flee or Fight");
                Console.WriteLine();
                Console.WriteLine(" Flee or Fight ");
                input = Console.ReadLine();

                if (input == "Flee")
                {
                    Console.WriteLine(" As you turn to Flee the mage fires a powerful spell made of Light killing you in one blow");
                    Console.WriteLine("YOU LOSE");

                }

                if (input == "Fight ")
                {
                    Console.WriteLine(" Ah a choice only a True Fighter would make I will bless you with a buff that will get you on the same speed of this Mages spells");
                    Console.WriteLine(" You feel your heart skip a beat as you see the Mage fired off his spell then you become surronded by pure Light and absorb its power granting a new buff (SPEED OF LIGHT)");

                    Console.WriteLine(" Now that you have the buff you are able to dodge the spell and ")

                }
                  
            }
        }
}
