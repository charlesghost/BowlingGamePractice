using System;

namespace BowlingGamePractice
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			BowlingGame bowlingGame = new BowlingGame();

			bowlingGame.GameRolls();
			bowlingGame.StrikeInGame();
			bowlingGame.GameScore();
			bowlingGame.GameScoreTotal();
        }

    }
}
