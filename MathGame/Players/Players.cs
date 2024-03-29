﻿using MathGame.Scores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Players
{
    public class Player
    {

        public string _name { get; set; }
        public int _id;
        public DateTime _createTime { get; set; }
        public Score score;

        public List<Score> _playerScores { get; set; }
        public int? _highScore { get; set; }

        public Player(string name)
        {
            _name = name;
            _id += 1;
            _createTime = DateTime.Now;
            _playerScores = new List<Score>();
        } 

        public static Player SelectPlayer(string name)
        {
            List<Player> players = PlayerList.GetPlayers();
            try
            {
                if (players.Count >= 1)
                {
                    for (int i = 0; i < players.Count; i++)
                    {
                        if (name == players[i]._name)
                        {
                            return players[i];
                        }
                    }
                }
                return CreatePlayer(name);
            }
            catch (NullReferenceException)
            {
                return CreatePlayer(name);
            }
        }

        private static Player CreatePlayer(string name)
        {
            Player player = new Player(name);
            return player; 
        }

        public void AddScoreToPlayer(Score score)
        {
            _playerScores.Add(score);
        }

    }
}
