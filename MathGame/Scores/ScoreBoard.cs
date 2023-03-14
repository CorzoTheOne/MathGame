using MathGame.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Scores
{
    public class ScoreBoard
    { 
        public Dictionary<Player, List<Score>> _allPlayerScoreboard;
        private static ScoreBoard uniqueInstance; 

        /// <summary>
        /// ScoreBoard is made using a singleton 
        /// 
        /// </summary>
        private ScoreBoard()
        {
           Dictionary<Player, List<Score>> allScores = new Dictionary<Player, List<Score>>();
            _allPlayerScoreboard = allScores;
        }
        public static ScoreBoard GetInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new ScoreBoard();
            }
            return uniqueInstance;
        }

        /// <summary>
        /// Display the scoreboard menu 
        ///     1. takes player name and shows that players scores
        ///     2. displays the highscores
        /// </summary>
        public static void ScoreboardMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Scoreboard menu, you have the following options:");
            Console.WriteLine("(1) to view scoreboard of all games played");
            Console.WriteLine("(2) to search for a specific players games");
            string input = Console.ReadLine();
            if (input == "1")
            {
                DisplayScoreboard();
                Console.WriteLine();
                Console.WriteLine("Press enter to return to main menu");
                Console.ReadLine();
                MainMenu.DisplayMainMenu();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("NOT IMPLEMENT YET!!");
                Thread.Sleep(3000);
                MainMenu.DisplayMainMenu();
            }
        }
        public static void DisplayScoreboard()
        {
            foreach (KeyValuePair<Player, List<Score>> kvp in uniqueInstance._allPlayerScoreboard)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
        }

        public void AddScoreToScoreboard(Player player, List<Score>? score)
        {
            Console.WriteLine(_allPlayerScoreboard);
            uniqueInstance._allPlayerScoreboard.Add(player, score);
        }
        /// <summary>
        /// TODO : Find a way to store/get the 10 highest scores from the scoreboard
        /// TODO : Probably just find the 10 highest and display them separately.
        /// </summary>
        public static void DisplayHighScores()
        {
        }
    }
}
