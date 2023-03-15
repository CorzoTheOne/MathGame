using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Scores
{
    public class Score
    {
        public static int _score = 0;
        private static DateTime _creationTime ;


        public static void IncrementScore()
        {
            _score = _score + 1;
        }

        public static void DecrementScore()
        {
            _score -= 1;
        }

        public void SetGameStats(int score)
        {
            _score = score;
            _creationTime = DateTime.Now;
        }
        public (int, DateTime) GetScore()
        {
            return (_score, _creationTime);
        }
    }
}
