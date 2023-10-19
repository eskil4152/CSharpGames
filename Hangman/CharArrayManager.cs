using System;
namespace CSharpGames.Hangman
{
	public class CharArrayManager
	{
		public static void FillWithEmpty(char[] chars)
		{
			for (int i = 0; i < chars.Length; i++)
			{
				chars[i] = '-';
			}
		}

		public static char[] Splitter(string word)
		{
			int length = word.Length;
            char[] splittedWord = new char[length];

            for (int i = 0; i < length; i++)
			{
				splittedWord[i] = word[i];
			}

			return splittedWord;
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

