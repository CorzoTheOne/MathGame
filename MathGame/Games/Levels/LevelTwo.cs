using MathGame.Games.Levels.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Games.Levels
{
    // TODO : Move the display logic to the LevelDisplaySelector instead. 
    internal class LevelTwo : ILevelMaker
    {
        public static (List<int>, int) RectCalculateArea() 
        {
            List<int> sides = new List<int>();

            Random number = new();
            sides.Add(number.Next(5, 20));
            sides.Add(number.Next(5, 10));

            int result = sides[0] * sides[1];
            return (sides, result);
        }
        public static (List<int>, int) RectCalculateCircumference() 
        {
            List<int> sides = new List<int>();

            Random number = new();
            sides.Add(number.Next(5, 20));
            sides.Add(number.Next(5, 10));

            int result = (sides[0] + sides[1]) * 2;
            return (sides, result);
        }
        public static (List<int>, int) TriangleCalculateArea() 
        {
            List<int> values = new List<int>();

            Random number = new();
            int triBase = number.Next(10, 20);
            int triHeight = number.Next(10, 20);

            values.Add(triBase);
            values.Add(triHeight);

            int result = triBase * triHeight / 2;
            return (values, result);
        }
        public static (List<int>, int) TriangleCalculateCircumference() 
        {
            List<int> sides = new List<int>();

            Random number = new();
            sides.Add(number.Next(5, 20));
            sides.Add(number.Next(5, 20));
            sides.Add(number.Next(5, 20));

            int result = sides.Sum();
            return (sides, result);
        }


        public static List<(Func<(List<int>, int)>, string)> PrepareQuestions() 
        {
            List<(Func<(List<int>, int)>, string)> questions = new();
            Random random = new();

            for (int i = 0; i < 10; i++)
            {
                int t = random.Next(1, 5);
                switch (t)
                {
                    case 1:
                        questions.Add((RectCalculateArea, "rectArea"));
                        break;
                    case 2:
                        questions.Add((RectCalculateCircumference, "rectCircum"));
                        break;
                    case 3:
                        questions.Add((TriangleCalculateArea, "triArea"));
                        break;
                    case 4:
                        questions.Add((TriangleCalculateCircumference, "triCircum"));
                        break;
                }
            }
            return questions;
        }
    }
}
