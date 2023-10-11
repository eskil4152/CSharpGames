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
			Console.ForegroundColor = ConsoleColor.Black;
			Console.WriteLine(message);
		}

		public static void DisplayError(string message)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(message);
			Console.ForegroundColor = ConsoleColor.Black;
		}

		public static void Spacer()
		{
			Console.WriteLine();
		}
	}
}

