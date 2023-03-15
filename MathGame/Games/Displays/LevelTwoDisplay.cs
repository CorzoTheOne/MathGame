using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Games.Displays
{
    public static class LevelTwoDisplay
    {
        public static StringBuilder Display(string func, List<int> numbers)
        {
            StringBuilder sb = new StringBuilder();
            switch (func)
            {
                case ("rectArea"):
                    sb.AppendLine($"The rectangle has height {numbers[0]} and width {numbers[1]}.");
                    sb.AppendLine($"What is the area? ({numbers[0]} * {numbers[1]} = ??)");

                    break;
                case ("rectCircum"):
                    sb.AppendLine($"The rectangle has height {numbers[0]} and width {numbers[1]}.");
                    sb.AppendLine($"What is the area? (({numbers[0]} + {numbers[1]}) * 2 = ??)");
                    break;
                case ("triArea"):
                    sb.AppendLine($"The triangle has base: {numbers[0]}, and height: {numbers[1]}.");
                    sb.AppendLine($"What is the Area? (Base * Height * 1/2) = ??");
                    break;
                case ("triCircum"):
                    sb.AppendLine($"The triangle has sides: {numbers[0]}, {numbers[1]}, {numbers[2]}");
                    sb.AppendLine($"What is its circumference? (side + side + side");
                    break;
            }
            return sb;
        }
    }
}
