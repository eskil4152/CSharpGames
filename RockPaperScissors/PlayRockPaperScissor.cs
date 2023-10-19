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
			int streak = 0;

			while (playing)
			{
				Interface.DisplayMessage("Rock, paper, scissors?");

				HandValue userChoice = InputChecker.RockPaperScissorsCheck();
				HandValue computerChoice = GetComputerHand.GenerateHand();

				ResultEnum result = WinChecker.Check(userChoice, computerChoice);

				if (result == ResultEnum.WIN)
				{
					Interface.DisplayMessage($"You win! Your {userChoice} beat my {computerChoice}!");
					streak++;
				} else if (result == ResultEnum.LOSE)
				{
					Interface.DisplayMessage($"You lose! My {computerChoice} beat your {userChoice}!");
					streak = 0;
				} else
				{
					Interface.DisplayMessage("DRAW!");
				}

				playing = KeepPlaying.KeepPlayingCheck("Rock, Paper, Scissors");
			}

		}
	}
}

