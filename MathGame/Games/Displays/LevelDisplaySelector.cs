using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Games.Displays
{
    public static class LevelDisplaySelector
    {
        /// <summary>
        /// Handles the display selection for each Level. 
        /// TODO : Add display for LevelTwo. 
        /// </summary>
        /// <param name="level"></param>
        /// <param name="func"></param>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static StringBuilder DisplayLevel(int level, string func, List<int> numbers)
        {
            switch (level)
            {
                case 1:
                    return LevelOneDisplay.Display(func, numbers);
                case 2:
                    return LevelTwoDisplay.Display(func, numbers);
                default:
                    break;
            }
            return new StringBuilder();
        }

        public static void DisplayActiveQuestion()
        {
            ConsoleColor previousColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
        }
        public static void DisplayInactiveQuestion()
        {

        }
    }
}
