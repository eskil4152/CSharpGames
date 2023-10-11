using System;
namespace CSharpGames.Hangman
{
	public class PlayHangman
	{
		public static async Task Play()
		{
			Interface.SetTitle("Hangman");

			bool playing = true;
			bool guessedWord = false;

			char[] randomWordSplit;

            int streak = 0;
            int guesses;

            while (playing)
			{
				List<char> usedLetters = new();

				Interface.DisplayMessage("Please wait while we get a word by random...");

				string? randomWord = await GetWord.GetRandomWordAsync();

				if (string.IsNullOrEmpty(randomWord))
					continue;

				Interface.DisplayMessage("The word is " + randomWord.Length + " letters long");
				Interface.DisplayMessage("How many guesses do you want?");

				guesses = InputChecker.IntCheck();

				randomWordSplit = SplitWordToArray.Splitter(randomWord);
				char[] correctlyGuessedLetters = new char[randomWordSplit.Length];

				CharArrayManager.FillWithEmpty(correctlyGuessedLetters);

                correctlyGuessedLetters = CharArrayManager.CheckMatch(correctlyGuessedLetters, randomWordSplit, ' ');
                correctlyGuessedLetters = CharArrayManager.CheckMatch(correctlyGuessedLetters, randomWordSplit, '-');

                while (!guessedWord && guesses > 0)
				{
                    Interface.ClearScreen();
                    Interface.DisplayMessage("You have used these letters so far: ");
                    CharArrayManager.Display(usedLetters.ToArray());

                    Interface.DisplayMessage("You have correctly guessed there letters: ");
                    CharArrayManager.Display(correctlyGuessedLetters);

					Interface.Spacer();

					Interface.DisplayMessage($"You have {guesses} guesses left");

					Interface.DisplayMessage("Make a guess:");

                    char guessedLetter = InputChecker.CharCheck(usedLetters);

                    usedLetters.Add(guessedLetter);
					                
                    correctlyGuessedLetters = CharArrayManager.CheckMatch(correctlyGuessedLetters, randomWordSplit, guessedLetter);

					if (randomWordSplit.SequenceEqual(correctlyGuessedLetters))
						guessedWord = true;

					guesses--;
				}

				if (guessedWord)
				{
					streak++;

					guessedWord = false;

					Interface.DisplayMessage("Congratulations, you won!");
					Interface.DisplayMessage($"Your current streak is {streak}");
					playing = KeepPlaying.KeepPlayingCheck("Hangman");
				} else
				{
                    guessedWord = false;

                    Interface.DisplayMessage("Sorry, you lost");
					Interface.DisplayMessage($"You lost your {streak} winning streak");

					playing = KeepPlaying.KeepPlayingCheck("Hangman");
				}
            }
		}
	}
}