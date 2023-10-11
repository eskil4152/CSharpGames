using System;
namespace CSharpGames.NumberGuesser
{
	public class PlayNumberGuesser
	{
		public static void Play()
		{
            Interface.SetTitle("Number Guesser");
            bool playing = true;
			bool isGuessed;
			string? minString;
			string? maxString;
			string? keepPlaying;

			string? guessString;
			int? randomNumber;
			            
			Interface.DisplayMessage("Welcome to numberguesser!");

			while (playing)
			{
				isGuessed = false;

				Interface.DisplayMessage("Please enter a minimum number");
				minString = Console.ReadLine();

				Interface.DisplayMessage("Please enter a maximum number");
				maxString = Console.ReadLine();

				if (!string.IsNullOrEmpty(minString) && !string.IsNullOrEmpty(maxString) &&
					int.TryParse(minString, out int minInt) && int.TryParse(maxString, out int maxInt))
				{
					randomNumber = Range.CheckRange(minInt, maxInt);
					if (randomNumber != null)
					{
                        Interface.DisplayMessage("I have chosen a number fitting your critera, please make a guess!");

						while (!isGuessed)
						{
                            guessString = Console.ReadLine();

                            if (!string.IsNullOrEmpty(guessString) && int.TryParse(guessString, out int guessInt))
                            {
								if (guessInt == randomNumber)
								{
                                    Interface.DisplayMessage("CORRECT!");

									KeepPlaying.AskToKeepPlaying();

									keepPlaying = Console.ReadLine();
									playing = KeepPlaying.Check(keepPlaying);

									isGuessed = true;
                                }
								else
									Interface.DisplayMessage("Wrong, try again");
                            }
                            else
                            {
                                Interface.DisplayMessage("Invalid guess");
                            }
                        }
                    } else
					{
                        Interface.DisplayMessage("Minimum must be less than maximum");
                    }
				} else
				{
					Interface.DisplayMessage("Invalid input, try again");
				}
			}
		}
	}
}

