using MathGame.Players;
using MathGame.Scores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Games
{
    public class Game
    {
        public int _level;

        public Score _score; 

        public void StartGame()
        {
            Console.WriteLine("Welcome to the game!\n");
            Console.WriteLine("Please enter your name:");
            string player_name = Console.ReadLine();
            Player player = Player.SelectPlayer(player_name);

        }
    }
}
