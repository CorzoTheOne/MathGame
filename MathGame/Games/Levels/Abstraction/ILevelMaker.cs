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

        static List<Func<int>> PrepareQuestions() 
        {
            List<Func<int>> result = default;
            return result;
        }

    }
}
