using System;
namespace CSharpGames.RockPaperScissors
{
	public class GetComputerHand
	{
        public static HandValue GenerateHand()
		{
			Random random = new();
			int handInt = random.Next(1, 4);

            var handValue = handInt switch
            {
                1 => HandValue.ROCK,
                2 => HandValue.PAPER,
                3 => HandValue.SCISSORS,
                _ => HandValue.ROCK,
            };

            return handValue;
		}
	}
}

