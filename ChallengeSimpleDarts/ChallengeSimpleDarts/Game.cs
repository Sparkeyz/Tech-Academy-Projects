using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeSimpleDarts
{
    public class Game
    {
        private Player _player1;
        private Player _player2;

        private Random _random;

        public Game(string player1Name, string player2Name)
        {
            _player1 = new Player();
            _player1.Name = player1Name;
            _player2 = new Player();
            _player2.Name = player2Name;

            _random = new Random();
        }

        public Game()
        {
            _player1 = new Player();
            _player1.Name = "Player 1";
            _player2 = new Player();
            _player2.Name = "Player 2";

            _random = new Random();
        }

        public string Play()
        {
            while(_player1.Score < 300 && _player2.Score < 300)
            {
                PlayRound(_player1);
                PlayRound(_player2);
            }
            return displayResults();
        }

        private string displayResults()
        {
            string result = String.Format("{0}: {1}<br />{2}: {3}",
                _player1.Name, _player1.Score, _player2.Name, _player2.Score);

            return result += "<br />Winner: " + (_player1.Score > _player2.Score ?
                _player1.Name : _player2.Name); 
            /*This is a ternary operator, equivalent to if player 1 score > player 2
            score, then add player 1's name, else add player 2's name*/
        }

        private void PlayRound(Player player)
        {
            for (int i = 0; i < 3; i++)
            {
                Dart dart = new Dart(_random);
                dart.Throw();
                Score.ScoreDart(player, dart);
            }
        }
    }
}