using MathGame.Games;
using MathGame.Players;
using MathGame.Scores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    public static class MainMenu
    {
        public static void DisplayMainMenu()
        {
            Console.Clear();
            Console.WriteLine("*** MAIN MENU ***");
            Console.WriteLine("You have the following options:\n");
            Console.WriteLine("1. View Players\n" +
                              "2. View Scoreboard\n" +
                              "3. Start Game\n" +
                              "4. Quit");
            while (true) 
            {
                string action = Console.ReadLine();
                switch (action)
                {
                    case "1":
                        PlayerList.DisplayPlayers();
                        break;
                    case "2":
                        ScoreBoard.ScoreboardMenu();
                        break;
                    case "3":
                        Game.StartGame();
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;  
                    default:
                        Console.WriteLine("Please select an option from the menu.");
                        continue;
                }
            }
        }
    }
}
