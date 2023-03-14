using MathGame.Games.Levels.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Games.Levels
{
    internal class LevelTwo : ILevelMaker
    {
        public static int RectCalculateArea() 
        {
            List<int> sides = new List<int>();

            Random number = new();
            sides.Add(number.Next(5, 20));
            sides.Add(number.Next(5, 10));

            Display("rectArea", sides);

            int result = sides[0] * sides[1];
            return result;
        }
        public static int RectCalculateCircumference() 
        {
            List<int> sides = new List<int>();

            Random number = new();
            sides.Add(number.Next(5, 20));
            sides.Add(number.Next(5, 10));

            Display("rectCircum", sides);

            int result = (sides[0] + sides[1]) * 2;
            return result;
        }
        public static int TriangleCalculateArea() 
        {
            List<int> values = new List<int>();

            Random number = new();
            int triBase = number.Next(10, 20);
            int triHeight = number.Next(10, 20);

            values.Add(triBase);
            values.Add(triHeight);

            Display("TriArea", values);

            int result = triBase * triHeight / 2;
            return result;
        }
        public static int TriangleCalculateCircumference() 
        {
            List<int> sides = new List<int>();

            Random number = new();
            sides.Add(number.Next(5, 20));
            sides.Add(number.Next(5, 20));
            sides.Add(number.Next(5, 20));

            Display("TriCircum", sides);

            int result = sides.Sum();
            return result;
        }
        public static void Display(string func, List<int> numbers)
        { 
            switch (func)
            {
                case ("rectArea"):
                    Console.WriteLine($"The rectangle has height {numbers[0]} and width {numbers[1]}.");
                    Console.WriteLine($"What is the area? ({numbers[0]} * {numbers[1]} = ??)");
                    break;
                case ("rectCircum"):
                    Console.WriteLine($"The rectangle has height {numbers[0]} and width {numbers[1]}.");
                    Console.WriteLine($"What is the area? (({numbers[0]} + {numbers[1]}) * 2 = ??)");
                    break;
                case ("TriArea"):
                    Console.WriteLine($"The triangle has base: {numbers[0]}, and height: {numbers[1]}.");
                    Console.WriteLine($"What is the Area? (Base * Height * 1/2) = ??");
                    break;
                case ("TriCircum"):
                    Console.WriteLine($"The triangle has sides: {numbers[0]}, {numbers[1]}, {numbers[2]}");
                    Console.WriteLine($"What is its circumference? (side + side + side");
                    break;
            }
        }

        public static List<Func<int>> PrepareQuestions() 
        {
            List<Func<int>> questions = new();
            Random random = new();

            for (int i = 0; i < 10; i++)
            {
                int t = random.Next(1, 5);
                switch (t)
                {
                    case 1:
                        questions.Add(RectCalculateArea);
                        break;
                    case 2:
                        questions.Add(RectCalculateCircumference);
                        break;
                    case 3:
                        questions.Add(TriangleCalculateArea);
                        break;
                    case 4:
                        questions.Add(TriangleCalculateCircumference);
                        break;
                }
            }
            return questions;
        }
    }
}
