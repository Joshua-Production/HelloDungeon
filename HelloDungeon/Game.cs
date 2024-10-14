using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace HelloDungeon{

}
internal class Game
{
    /// <summary>
    /// Function for printing the player's stats
    /// </summary>
    /// <param name="player">The instance of a player whose stats this function is printing</param>
    static void PrintPlayerStats(Player player)
    {
        Console.WriteLine(player.Name);
        Console.WriteLine(" Health:" + player.Health);
        Console.WriteLine(" Mana:  " + player.Mana);
        Console.WriteLine(" Gold:  " + player.Gold);
        Console.WriteLine(" Xp:    " + player.Xp);
        Console.WriteLine(" HealthPotions:  " + player.HealthPotion);
        Console.WriteLine(" ManaPotion:  " + player.ManaPotion);
        Console.WriteLine(" Food:  " + player.Food);

    }
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
    /// <param name="description">Describes the options</param>           
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
    int GetInput(string description, string option1, string option2, string option3)
    {
        // Players Typed input
        string input = "";
        int inputRecieved = 0;

        // Input loop
        while (inputRecieved != 1 && inputRecieved != 2 && inputRecieved != 3)
        {
            // Print options
            Console.WriteLine(description);
            Console.WriteLine("1. " + option1);
            Console.WriteLine("2. " + option2);
            Console.WriteLine("3. " + option3);
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
            else if (input == "3" || input == option3)
            {

                // Set inputReciedved to be the third option
                inputRecieved = 3;
            }
            // If none are true
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
        Player player1 = new Player(" Jim", Health: 20.0f, Mana: 50.0f, Stamina: 100, Gold: 5, Xp: 0.0f, HealthPotion: 5, ManaPotion: 5, Food: 3, Role: "", PlayerInput: "");

        Console.WriteLine(" You find yourself inside of what seems to be a cave with no exit or entrance ");
        Console.WriteLine("");
        Console.WriteLine(" DEV (Hello Jim) ");
        Console.WriteLine(" DEV (I see that you found my dungeon... Now i will give you a choice would you like to be a Warrior or a Wizard?) ");

        //default input value reset to 0

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


        Console.WriteLine(" DEV(So, you chose) " + player1.Role);
        Console.WriteLine("");
        Console.WriteLine(" DEV(These are your stats.)");
        Console.WriteLine("");

        input = GetInput(" Dev (Now I will give you a choice of a accessory)", " Rick the Rock ", " Pablo ", " International Space Station");

        if (input == 1)
        {
            Console.WriteLine(" Player has obtained Rick the Rock");
        }
        else if (input == 2)
        {
            Console.WriteLine(" Player has obtained Pablo");
        }
        else if (input == 3)
        {
            Console.WriteLine(" Player has obtained the entire International Space Station ");
        } 



        //prints the players stats
        PrintPlayerStats(player1);
        Console.WriteLine(" Press Any Key To Continue ");
        Console.WriteLine("");
        Console.ReadKey();

        Console.Clear();

        input = 0;

        input = GetInput(" DEV (Two Doors appear infront of you These doors may look the same but the path they bring you on is for you to decide) ", "Door 1", "Door 2");

        if (input == 1)
        {
            input = 0;
            input = GetInput("As you enter Door 1 you see a giant goblin will you", "Flee", "Fight");
            

                if (input == 1)
                {
                    Console.WriteLine(" As you turn to Flee the door slams shut trapping you in the room forcing you to fight.");
                    Console.WriteLine(" You turn back around to see that the goblin is about to strike you. ");
                    Console.WriteLine("You atempt to block but the goblin hits you! ");
                    Console.WriteLine(" Cutting your HP from " + player1.Health + " To " + player1.Health / 2f);

                    Console.Write(" Press any key to continue ");
                    Console.ReadKey();
                    input = 0;
                    input = GetInput(" As you get back up you dash at the goblin how will you attack? ", " Stong single attack ", " Light double attack");
                    if (input == 1)
                    {
                        Console.WriteLine(" You attack the Goblin with all of your might and kill it in one attack ");
                        Console.WriteLine(" YOU WIN ");
                    }
                    if (input == 2)
                    {
                        Console.WriteLine(" You attack the Goblin with 2 swift attacks killing it ");
                        Console.WriteLine(" YOU WIN");
                        input = 0; ;
                    }


                }

                if (input == 2)
                {

                    Console.WriteLine(" DEV (Ah so you choose to fight NICE the heart of a fighter just for that here is a buff)");
                    Console.WriteLine(" BUFF(NEXT ATTACK IS A 1 SHOT");
                    Console.WriteLine("You dash towards the goblin killing it in one attack");
                    Console.WriteLine(" YOU WIN");
                    input = 0;

                }

            
        }

        if (input == 2)
        {



            Console.WriteLine(" As you enter door 2 you see there is a wizard waiting for you.");
            Console.WriteLine(" You turn around and try to runaway but,");
            Console.WriteLine(" the wizard hit you with a bolt of light cutting your HP from " + player1.Health + " To " + player1.Health / 2f);
            Console.WriteLine(" Press any key to continue ");
            Console.ReadKey();
            Console.Clear();




            Console.WriteLine(" You get back up from being hit");
            Console.WriteLine(" DEV (Oh you didnt die i see well heres a speed buff you are gonna need it if you wanna keep up with the wizards spells)");
            Console.WriteLine(" BUFF(LIGHT SPEED) ");
            Console.WriteLine(" As the wizard charges up and fires his spell you dodge it and appear behind him killing him in one blow");
            Console.WriteLine(" YOU WIN");

        }


         
         


        /// <summary>
        /// Function for printing the player's stats
        /// </summary>
        /// <param name="player">The instance of a player whose stats this function is printing</param>
        static void PrintPlayerStats(Player player)
        {
            Console.WriteLine(player.Name);
            Console.WriteLine(" Health:" + player.Health);
            Console.WriteLine(" Mana:  " + player.Mana);
            Console.WriteLine(" Gold:  " + player.Gold);
            Console.WriteLine(" Xp:    " + player.Xp);
            Console.WriteLine(" HealthPotions:  " + player.HealthPotion);
            Console.WriteLine(" ManaPotion:  " + player.ManaPotion);
            Console.WriteLine(" Food:  " + player.Food);

        }





    }
}


        

