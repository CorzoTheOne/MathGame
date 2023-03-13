using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathGame;

namespace MathGame.Players
{
    public static class PlayerList
    {
        private static readonly List<Player>? _players;

        public static void AddPlayer(Player player)
        {
            _players.Add(player);
        }

        public static void RemovePlayer(Player player)
        {
            _players.Remove(player);
        }

        public static List<Player> GetPlayers()
        {
            return _players;
        }

        public static void DisplayPlayers()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine(" Name         | Created @   | Highest Score   \n");
                foreach (Player player in _players)
                {
                    if (player != null)
                    {
                        Console.WriteLine(String.Format("{0, -10} | {1, -10} | {2, -10}", player._name, player._createTime, player._highScore));
                    }        
                }
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("To return to main menu, press enter");
                Console.ReadKey();
                Console.WriteLine("Returning to main menu");
                Thread.Sleep(1000);
                MainMenu.DisplayMainMenu();
            }
            catch 
            {
                Console.WriteLine("There are currently no players in the list.\n");
                Console.WriteLine("To return to main menu, press enter");
                Console.ReadKey();
                Thread.Sleep(1000);
                MainMenu.DisplayMainMenu();
            }
        }
    }
}
