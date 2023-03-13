using MathGame.Games.Levels.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Games.Levels
{
    public class LevelOne : ILevelMaker
    {
        public List<Func<int>> _questions;

        public static int Add()
        {
            List<int> numbers = new();

            Random length = new();
            for (int i = 0; i < length.Next(2, 5); i++)
            {
                numbers.Add(length.Next(99));
            }
            Display("add", numbers);

            int result = numbers.Sum();

            return result;
        }

        public static int Subtract()
        {
            List<int> numbers = new();

            Random length = new();
            for (int i = 0; i < length.Next(2, 4); i++)
            {
                numbers.Add(length.Next(99));
            }
            Display("subtract", numbers);

            int head = numbers[0];
            List<int> rest = numbers.GetRange(1, numbers.Count - 2);
            for (int i = 0; i < rest.Count(); i++)
            {
                head = head - rest[i];
            }

            return head;
        }


        public static int Multiply() 
        {
            List<int> numbers = new();

            Random length = new();
            for (int i = 0; i < length.Next(2, 3); i++)
            {
                numbers.Add(length.Next(30));
            }
            Display("multiply", numbers);

            int result = 1;
            for (int i = 0; i < numbers.Count; i++)
            {
                result = result * numbers[i];
            }

            return result;
        }

        // TODO :
        public static int Divide()
        {
            List<int> numbers = new();

            Random length = new();
            numbers.Add(length.Next(50, 99));
            numbers.Add(length.Next(1, 18));
            Console.WriteLine("Divide without including remainders:\n");
            Display("divide", numbers);

            int result = numbers[0] / numbers[1];

            return result;
        }

        private static void Display(string func, List<int> numbers)
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
            Console.WriteLine(sb);


        }

        public List<Func<int>> PrepareQuestions()
        {
            throw new NotImplementedException();
        }
    }
}
