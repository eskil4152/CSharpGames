using System;
namespace CSharpGames.RockPaperScissors
{
	public class GetComputerHand
	{
        public static HandValue GenerateHand()
		{
			Random random = new();
			int handInt = random.Next(1, 4);

			HandValue value = (HandValue)handInt;

			return value;
		}
	}
}

