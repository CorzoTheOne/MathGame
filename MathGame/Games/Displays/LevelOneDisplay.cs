using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Games.Displays
{
    public static class LevelOneDisplay
    {
/*        public string type;
        public List<int> numbers;

        public LevelOneDisplay(string type, List<int> numbers)
        { 
        }*/

        public static StringBuilder Display(string func, List<int> numbers)
        {
            string type;
            switch (func)
            {
                case "add":
                    type = "+";
                    break;
                case "subtract":
                    type = "-";
                    break;
                case "multiply":
                    type = "*";
                    break;
                case "divide":
                    type = "/";
                    break;
                default:
                    type = "ERROR";
                    break;
            }
            StringBuilder sb = new("Calculate: ");
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers.Count - i == 1)
                {
                    sb.Append($"{numbers[i]} = ??");
                }
                else
                {
                    sb.Append($"{numbers[i]} {type} ");
                }
            }
            return sb;
        }
    }
}
