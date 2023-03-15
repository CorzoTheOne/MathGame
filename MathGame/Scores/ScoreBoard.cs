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

        /// <summary>
        /// Displays all games currently stored in the "database"
        /// </summary>
        public static void DisplayScoreboard()
        {
            Console.Clear();
            Console.WriteLine("Player Games Menu\n");

            // Make an instance of the scoreboard in case the user loads it before any games has been played.
            ScoreBoard scoreBoard = GetInstance();

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("  Name       | Score      | Time      ");
            foreach (KeyValuePair<Player, List<Score>> kvp in uniqueInstance._allPlayerScoreboard)
            {
                // Unpacking the Player name and the Score object stored in the list.
                string name = kvp.Key._name;
                Score playScore = kvp.Value[0];
                (int, DateTime) stats = playScore.GetScore();
                int score = stats.Item1;
                DateTime date = stats.Item2;


                Console.WriteLine(String.Format("  {0, -10} | {1, -10} | {2, -10}", name, score, date));
            }
        }

        /// <summary>
        /// Called by Play.GameOver() to add the player and their score to the ScoreBoard.
        /// </summary>
        /// <param name="player"></param>
        /// <param name="score"></param>
        public void AddScoreToScoreboard(Player player, List<Score>? score)
        {
            Console.WriteLine(_allPlayerScoreboard);
            uniqueInstance._allPlayerScoreboard.Add(player, score);
        }
    }
}
