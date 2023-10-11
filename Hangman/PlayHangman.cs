using System;
namespace CSharpGames.Hangman
{
	public class PlayHangman
	{
		public static async Task Play()
		{
			Interface.SetTitle("Hangman");

			bool playing = true;
			int guesses;

			char[] randomWordSplit;
			char[] guessedLetters;

			while (playing)
			{
				Interface.DisplayMessage("Please wait while we get a word by random...");

				string? randomWord = await GetWord.GetRandomWordAsync();

				if (string.IsNullOrEmpty(randomWord))
					continue;

				Interface.DisplayMessage("The word is " + randomWord.Length + " letters long");
				Interface.DisplayMessage("How many guesses do you want?");
				string? guessesInput = Console.ReadLine();

				if (!string.IsNullOrEmpty(guessesInput) && int.TryParse(guessesInput, out int guessesInt)){
					guesses = guessesInt;
				} else
				{
					Interface.DisplayError("Invalid input, try again");
				}

				randomWordSplit = SplitWordToArray.Splitter(randomWord);

            }
		}
	}
}