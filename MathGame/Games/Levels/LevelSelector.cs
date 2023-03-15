using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Games.Levels
{
    public class LevelSelector
    {
        /// <summary>
        /// Called by Play to make list of questions from the appropriate level. 
        /// List<(Func<(List<int>, int)>, string)> 
        /// List, of Functions containing a, List of integers, and an integer, and a string... 
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        public static List<(Func<(List<int>, int)>, string)> ChooseLevel(int level)
        {
            List<(Func<(List<int>, int)>, string)> questions = new();
            switch (level)
            {
                case 1:
                    questions = LevelOne.PrepareQuestions();
                    break;
                case 2:
                    questions = LevelTwo.PrepareQuestions();
                    break;
                default:               
                    break;
            }
            return questions;
        }
    }
}
