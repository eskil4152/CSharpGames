using System;
namespace CSharpGames.Hangman
{
	public class PlayHangman
	{
		public static async void Play()
		{
			Interface.SetTitle("Hangman");

			bool playing = true;

			while (playing)
			{
				string? randomWord = await GetWord.GetRandomWordAsync();
                Console.WriteLine("Word gotten");

				Console.WriteLine("Keep playing?");
				Console.ReadLine();
            }
		}
	}
}