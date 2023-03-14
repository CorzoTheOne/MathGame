using MathGame.Players;
using MathGame.Scores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Games
{
    public static class Game
    {
        /// <summary>
        /// Selects/Creates the player
        /// Creates an instance of the play session. 
        /// </summary>
        public static void StartGame()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the game!\n");
            Console.WriteLine("Please enter your name:");
            string player_name = Console.ReadLine();
            Player player = Player.SelectPlayer(player_name);

            Play play = new Play(player);
            
            play.Round();

        }
    }
}
