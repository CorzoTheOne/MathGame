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
        private static readonly IDictionary<string, List<Score>>? _playerScoreboard; 


        /// <summary>
        /// Display the scoreboard menu 
        ///     1. takes player name and shows that players scores
        ///     2. displays the highscores
        /// </summary>
        public void ScoreboardMenu()
        {

        }
        public void DisplayScoreboard(string player)
        {

        }

        /// <summary>
        /// TODO : Find a way to store/get the 10 highest scores from the scoreboard
        /// TODO : Probably just find the 10 highest and display them separately.
        /// </summary>
        public void DisplayHighScores()
        {
        
        }
    }
}
