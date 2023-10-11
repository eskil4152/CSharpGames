using System;
namespace CSharpGames.NumberGuesser
{
	public class PlayNumberGuesser
	{
		public static void Play()
		{
			Interface.SetTitle("Number Guesser");
			bool playing = true;
			int numbersGuessed = 0;

			Interface.DisplayMessage("Welcome to numberguesser!");

			while (playing)
			{
				bool isGuessed = false;
				int? randomNumber = RandomGenerator.GetRandomNumber();

				if (randomNumber == null)
				{
					Interface.DisplayMessage("Invalid input, try again.");
					continue;
				}

				Interface.DisplayMessage("I have chosen a number fitting your critera, please make a guess!");

				while (!isGuessed)
				{
					string? guessString = Console.ReadLine();

					if (!string.IsNullOrEmpty(guessString) && int.TryParse(guessString, out int guessInt))
					{
						if (guessInt == randomNumber)
						{
							numbersGuessed++;
							Interface.Spacer();
							Interface.DisplayMessage($"CORRECT! You have now guessed {numbersGuessed} numbers!");
							isGuessed = true;
						}
						else
						{
                            Interface.DisplayMessage("Wrong, try again.");
                        }
					}
					else
					{
						Interface.DisplayMessage("Invalid guess, please enter a number.");
					}
				}

				playing = KeepPlaying.KeepPlayingCheck();
			}

			Interface.DisplayMessage("Hope you enjoyed your games of number guesser!");
		}
	}
}

