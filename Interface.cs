using System;
namespace CSharpGames
{
	public class Interface
	{

		public static void SetTitle(string title)
		{
			Console.Title = title;
		}

		public static void ClearScreen()
		{
			Console.Clear();
		}

		public static void DisplayMessage(string message)
		{
			Console.WriteLine(message);
		}

		public static void DisplayCharacters(char character)
		{
			Console.Write(character);
		}

		public static void DisplayError(string message)
		{
			ConsoleColor originalColor = Console.ForegroundColor;

			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(message);

			Console.ForegroundColor = originalColor;
		}

		public static void Spacer()
		{
			Console.WriteLine();
		}
	}
}

