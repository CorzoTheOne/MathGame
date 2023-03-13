using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Scores
{
    public class Score
    {
        public int _score = 0;
        private DateTime _creationTime ;

        public Score() 
        { 
        }

        public void IncrementScore()
        {
            _score = _score + 1;
        }

        public void DecrementScore()
        {
            _score -= 1;
        }
        public void ScoreTime()
        {
            _creationTime = DateTime.Now;
        }

        public (int, DateTime) SetGameStats()
        {
            return (_score, _creationTime);
        }
    }
}
