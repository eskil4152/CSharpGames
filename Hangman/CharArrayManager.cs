using System;
namespace CSharpGames.Hangman
{
	public class CharArrayManager
	{
		public static void Display(char[] chars)
		{
			foreach (char c in chars)
			{
				Interface.DisplayCharacters(c);
				Interface.DisplayCharacters(' ');
			}

			Interface.DisplayMessage("");
		}

		public static void FillWithEmpty(char[] chars)
		{
			for (int i = 0; i < chars.Length; i++)
			{
				chars[i] = '-';
			}
		}

		public static char[] CheckMatch(char[] correctlyGuessedLetters, char[] randomWord, char guessedLetter)
		{
			char[] updatedCorrectlyGuessedLetters = correctlyGuessedLetters;

			if (randomWord.Contains(guessedLetter)){
                for (int i = 0; i < randomWord.Length; i++)
                {
                    if (randomWord[i] == guessedLetter)
                    {
                        updatedCorrectlyGuessedLetters[i] = guessedLetter;
                    }
                }
            }
			else
			{
				Interface.DisplayMessage("No match");
			}

			return updatedCorrectlyGuessedLetters;
		}
	}
}

