using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Games.Levels
{
    public class LevelSelector
    {
        public List<Func<int>> ChooseLevel(int level)
        {
            List<Func<int>> questions = new List<Func<int>>();
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
