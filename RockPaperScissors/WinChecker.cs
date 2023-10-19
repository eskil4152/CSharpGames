using System;
namespace CSharpGames.RockPaperScissors
{
	public class WinChecker
	{
		public static ResultEnum Check(HandValue UserHand, HandValue ComputerHand)
		{
			ResultEnum result;

			switch (UserHand)
			{
				case HandValue.ROCK:
					if (ComputerHand == HandValue.PAPER)
					{
						result = ResultEnum.LOSE;
					} else if (ComputerHand == HandValue.SCISSORS)
					{
						result = ResultEnum.WIN;
					} else
					{
						result = ResultEnum.DRAW;
					}
					break;

				case HandValue.PAPER:
                    if (ComputerHand == HandValue.PAPER)
                    {
                        result = ResultEnum.DRAW;
                    }
                    else if (ComputerHand == HandValue.SCISSORS)
                    {
                        result = ResultEnum.LOSE;
                    }
                    else
                    {
                        result = ResultEnum.WIN;
                    }
                    break;

                case HandValue.SCISSORS:
					if (ComputerHand == HandValue.PAPER)
					{
                        result = ResultEnum.WIN;
                    } else if (ComputerHand == HandValue.SCISSORS)
					{
                        result = ResultEnum.DRAW;
                    } else
					{
                        result = ResultEnum.LOSE;
                    }
					break;

				default:
					result = ResultEnum.DRAW;
					break;
			}

			return result;
		}
	}
}

