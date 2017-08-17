using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeSimpleDarts
{
    public class Dart
    {
        public int Score { get; set; }
        public bool IsDouble { get; set; }
        public bool IsTriple { get; set; }
        private Random _random;

        public Dart(Random random)
        {
            _random = random;
            Throw();
        }

        public void Throw()
        {
            Score = _random.Next(0, 21);
            if (Score == 0) Score = 25;
            int mult = _random.Next(0, 100);
            IsDouble = false;
            IsTriple = false;
            if (mult < 5) IsDouble = true;
            else if (mult >= 95) IsTriple = true;
        }

    }
}