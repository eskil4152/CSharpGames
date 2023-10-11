using System;
namespace CSharpGames.Hangman
{
	public class ProgressTracker
	{
		public static void ShowProgress(char[] usedLetters, char[] correctlyGuessedLetters, int guesses)
		{
            Interface.ClearScreen();
            Interface.DisplayMessage("You have used these letters so far: ");
            Interface.DisplayCharArrays(usedLetters);

            Interface.DisplayMessage("You have correctly guessed there letters: ");
            Interface.DisplayCharArrays(correctlyGuessedLetters);

            Interface.Spacer();

            Interface.DisplayMessage($"You have {guesses} guesses left");
        }
	}
}

