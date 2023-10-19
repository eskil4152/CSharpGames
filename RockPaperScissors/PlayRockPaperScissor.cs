using System;
namespace CSharpGames.RockPaperScissors
{
	public class PlayRockPaperScissors
	{
		public static void Play()
		{
			Interface.SetTitle("Rock, Paper, Scissor");

			Console.WriteLine("Welcome to rock, paper, scissors!");

			bool playing = true;

			while (playing)
			{
				Interface.DisplayMessage("Rock, paper, scissors?");


				HandValue userChoice = InputChecker.RockPaperScissorsCheck();
				HandValue computerChoice = GetComputerHand.GenerateHand();
			}

		}
	}
}

