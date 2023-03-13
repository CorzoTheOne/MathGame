using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Games.Levels.Abstraction
{


    internal class LevelMain
    {
        private readonly List<Func<int>> _questions;

        public virtual List<Func<int>> PrepareQuestions()
        {
            return _questions;
        }
    }
}
