using System;

namespace rpg_game_code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            rpg_class newPlayer;

            Console.WriteLine("Say your type:\n");
            Console.WriteLine("|   Mage  |" + 
                            "\n| Warrior |"+
                            "\n|  Priest |\n\n");

            string playerType = Console.ReadLine();

            newPlayer = new rpg_class(playerType);

            if(newPlayer.getError() == "Erro")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nType of player entered wrong");
                Environment.Exit(0);
            }

            string classPlayer = newPlayer.getPlayerType();
            int lvlPlayer = newPlayer.getLvL();
            float intPlayer = newPlayer.getIntelligence();
            float powerPlayer = newPlayer.getPower();
            float strengthPlayer = newPlayer.getStrength();
            int staminaPlayer = newPlayer.getStamina();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n --STATUS-- \n"+
                              "O "+ classPlayer +
                            "\nEsta no Lvl: " + lvlPlayer +
                            "\nInteligencia: " + intPlayer +
                            "\nPoder : " + powerPlayer +
                            "\nForca : " + strengthPlayer +
                            "\nStamina : " + staminaPlayer);
        }
    }
}
