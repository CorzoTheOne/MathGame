using MathGame.Games.Levels.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Games.Levels
{
    /// <summary>
    /// This class is responsible for Level 1 questions
    /// It contains each function used in level 1 - as well as the packager that 
    /// is called to add 10 rounds to the play session.
    /// 
    /// </summary>
    public class LevelOne : ILevelMaker
    {
        public static (List<int>, int) Add()
        {
            List<int> numbers = new();

            Random length = new();
            for (int i = 0; i < length.Next(2, 5); i++)
            {
                numbers.Add(length.Next(99));
            }

            int result = numbers.Sum();

            return (numbers, result);
        }

        public static (List<int>, int) Subtract()
        {
            List<int> numbers = new();

            Random length = new();
            for (int i = 0; i < length.Next(2, 4); i++)
            {
                numbers.Add(length.Next(99));
            }

            int head = numbers[0];
            List<int> rest = numbers.GetRange(1, numbers.Count - 1);
            for (int i = 0; i < rest.Count(); i++)
            {
                head = head - rest[i];
            }

            return (numbers, head);
        }


        public static (List<int>, int) Multiply() 
        {
            List<int> numbers = new();

            Random length = new();
            for (int i = 0; i < length.Next(2, 3); i++)
            {
                numbers.Add(length.Next(30));
            }

            int result = 1;
            for (int i = 0; i < numbers.Count; i++)
            {
                result = result * numbers[i];
            }

            return (numbers, result);
        }

        public static (List<int>, int) Divide()
        {
            List<int> numbers = new();

            Random length = new();
            numbers.Add(length.Next(50, 101));
            numbers.Add(length.Next(1, 19));

            int result = numbers[0] / numbers[1];

            return (numbers, result);
        }

        /// <summary>
        /// Display() - Uses a switch and a StringBuilder to correctly format and display the question.
        /// </summary>
        /// <param name="func">string representation of the function fx. "add"</param>
        /// <param name="numbers">The list with values that are displayed in with correct formatting. </param>

        /// <summary>
        /// PrepareQuestions - Randomly selects functions that return integers to add to the list. 
        /// Called by Play(). 
        /// </summary>
        /// <returns>return a list of 10 functions that return integers.</returns>
        public static List<(Func<(List<int>, int)>, string)> PrepareQuestions()
        {
            List<(Func<(List<int>, int)>, string)> _questions = new();
            for (int i = 0; i < 10; i++)
            {
                Random selector = new(); 
                switch (selector.Next(1, 5))
                {
                    case 1:
                        _questions.Add((Add, "add"));

                        break;
                    case 2:
                        _questions.Add((Subtract, "subtract"));
                        break;
                    case 3: 
                        _questions.Add((Multiply, "multiply"));
                        break;
                    case 4:
                        _questions.Add((Divide, "divide"));
                        break;
                }
            }
            return _questions;
        }
    }
}
