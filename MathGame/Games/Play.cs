using MathGame.Games.Displays;
using MathGame.Games.Levels;
using MathGame.Players;
using MathGame.Scores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Games
{
    /// <summary>
    /// The Play class runs the game - loads the questions and handles game logic. 
    ///     Input:
    ///         Player object
    ///     Output:
    ///         Player, updated with an aggregated Score object, specific to the "play-session". 
    /// </summary>
    public class Play
    {
        private int _level = 1;
        private int answer;
        public Player _player;
        private int _score = 0;
        private int _lives = 3;
        private int _round = 0;
        public ScoreBoard _scoreBoard; 

        public Play(Player player) 
        {
            _player = player;
        }

        /// <summary>
        /// Handles game flow. 
        ///     Based on the current level, creates a list of questions to be asked doing the game. 
        ///         This is handled by calls to the 'LevelSelector' and 'LevelDisplaySelector' classes. 
        ///     Class also handles simple game logic - like tracking the rounds, score and lives of the player. 
        ///   End of game logic:
        ///     Creates an instance of the Score object, an aggregate of the player class.
        ///     Then constructs (or calls - if already constructed) the instance of the ScoreBoard (See ScoreBoard.cs)
        ///     
        /// </summary>
        public void Round()
        {

            List<(Func<(List<int>, int)>, string)> roundQuestions = LevelSelector.ChooseLevel(_level);

            foreach ((Func<(List<int>, int)>, string) question in roundQuestions)
            {
                // Displays current level and round before each question.
                _round++;
                Console.WriteLine($"Get ready! this is level: {_level} - Round {_round}\n");

                // Unpacking the question: 
                Func<(List<int>, int)> func = question.Item1;
                (List<int>, int) f = func();
                List<int> numberList = f.Item1;
                int result = f.Item2;
                string type = question.Item2;

                // Gets the correct question display for the level 
                StringBuilder display = LevelDisplaySelector.DisplayLevel(_level, type, numberList);
                Console.WriteLine(display);

                int answer = playerAnswer();
                if (answer == result)
                {
                    _score += 1;
                    Console.WriteLine("You're Correct! Amazing!");
                    Console.WriteLine($"Your score has increased to {_score}\n");
                }
                else
                {
                    WrongAnswer(result, answer);
                }
                Console.WriteLine();
            }

            _level += 1;
            Round();
        }

        public int playerAnswer()
        {
            bool response = true;
            while (response)
            { 
                try
                {
                    Console.WriteLine("Please input your answer: \n");
                    string input = Console.ReadLine();
                    answer = Int32.Parse(input);
                    response = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please type your answer as a whole integer with no additional characters (fx: 151, 23254, 2)");
                }
            }
            return answer;
        }

        public void WrongAnswer(int correctAnswer, int playerAnswer)
        {
            Console.WriteLine($"{playerAnswer} is incorrect");
            Console.WriteLine($"The correct answer is {correctAnswer}");
            LoseLife();
        }

        public void LoseLife()
        {
            _lives -= 1;
            if (_lives == 0)
            {
                GameOver();
            }
            Console.WriteLine($"Lives remaining {_lives}");
        }

        public void GameOver()
        {
            Console.WriteLine("You have lost your last life!");
            Console.WriteLine($"Your final score was {_score}");
            Console.WriteLine($"Thank you for playing {_player._name}");
            Console.WriteLine("You game will now be recorded! Please try again.");

            // Constructing the Score type with the score from the game. 
            Score finalScore = new Score();
            finalScore.SetGameStats(_score);

            // Giving the Score object to the Players aggregated Score property. 
            _player.score = finalScore;
            _player.AddScoreToPlayer(finalScore);
            Player testPlayer = _player;

            // Converting the Score to a list so it can be added to the ScoreBoard 
            // Last breath of a dying man... 
            List<Score> final = new List<Score>()
            { 
                finalScore 
            };
            ScoreBoard scoreBoard = ScoreBoard.GetInstance();

            scoreBoard.AddScoreToScoreboard(_player, final);

            // Returning the player to the Main Menu after a climaxing pause. 
            Console.WriteLine("You will be returned to the main menu in 5 seconds");
            Thread.Sleep(5000);
            MainMenu.DisplayMainMenu();
        }

    }
}
