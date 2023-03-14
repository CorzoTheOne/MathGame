using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Games.Levels.Abstraction
{
    public interface ILevelMaker
    {
        //public List<Func<int>>

        static List<(Func<int>, string)> PrepareQuestions() 
        {
            List<(Func<int>, string)> result = default;
            return result;
        }

    }
}
