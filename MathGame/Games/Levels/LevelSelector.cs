using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Games.Levels
{
    public class LevelSelector
    {
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
