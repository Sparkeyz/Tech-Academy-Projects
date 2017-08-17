using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeSimpleDarts
{
    public class Score
    {
        public static void ScoreDart(Player player, Dart dart)
        {
            int points = 0;
            if (dart.IsTriple) points = dart.Score * 3;
            else if (dart.IsDouble) points = dart.Score * 2;
            else points = dart.Score;

            if (dart.IsTriple && dart.Score == 0) points = 50;
            else if (dart.Score == 0) points = 25;
            player.Score += points;
        }
    }
}