using System;
namespace CSharpGames
{
	public class KeepPlaying
	{
		private static bool InputCheck()
		{
			string? input = Console.ReadLine();

			if (!string.IsNullOrEmpty(input) && input.ToLower().Equals("y"))
			{
				return true;
			}

			return false;
		}

		public static bool KeepPlayingCheck()
		{
			Interface.Spacer();

			Interface.DisplayMessage("Do you want to keep playing?");
			Interface.DisplayMessage("If so, press 'Y'");
			return InputCheck();
		}
	}
}

