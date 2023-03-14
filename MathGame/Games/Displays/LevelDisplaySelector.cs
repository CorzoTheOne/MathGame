using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Games.Displays
{
    public static class LevelDisplaySelector
    {
        public static StringBuilder DisplayLevel(int level, string func, List<int> numbers)
        {
            switch (level)
            {
                case 1:
                    return LevelOneDisplay.Display(func, numbers);
                    break;
                default:
                    break;
            }
            return new StringBuilder();
        }
    }
}
