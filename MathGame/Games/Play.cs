using MathGame.Games.Displays;
using MathGame.Games.Levels;
using MathGame.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Games
{
    /// <summary>
    /// The Play class runs the game - loads the questions and handles game logic. 
    ///     
    /// </summary>
    public class Play
    {
        private int _level = 1;
        private int answer;

        public Play() 
        {

        }

        public void Round()
        {
            List<(Func<(List<int>, int)>, string)> roundQuestions = LevelSelector.ChooseLevel(_level);

            foreach ((Func<(List<int>, int)>, string) question in roundQuestions)
            {
                // Unpacking the question: 
                Func<(List<int>, int)> func = question.Item1;
                (List<int>, int) f = func();
                List<int> numberList = f.Item1;
                int result = f.Item2;
                string type = question.Item2;

                // Gets the correct question display for the level 
                StringBuilder display = LevelDisplaySelector.DisplayLevel(_level, type, numberList);
                Console.WriteLine(display);

                // Console.WriteLine(func());
            }
        }

        public void QuestionTest(Func<int> func)
        {

            Console.WriteLine(func());
        }

        public int playerAnswer()
        {
            Console.WriteLine("Please input your answer: \n");
            bool response = true;
            while (response)
            { 
                try
                {
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
    }
}
