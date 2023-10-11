using System;
namespace CSharpGames.Hangman
{
	public class SplitWordToArray
	{
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
	}
}

