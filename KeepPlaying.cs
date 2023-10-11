using System;
namespace CSharpGames
{
	public class KeepPlaying
	{
		public static bool Check(String? s)
		{
			if (s != null && s.ToLower().Equals("y"))
			{
				return true;
			}

			return false;
		}

		public static void AskToKeepPlaying()
		{
			Interface.DisplayMessage("Do you want to keep playing?");
			Interface.DisplayMessage("If so, press 'Y'");
		}
	}
}

