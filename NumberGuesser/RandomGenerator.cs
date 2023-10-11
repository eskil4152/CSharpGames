namespace CSharpGames.NumberGuesser
{
    public class RandomGenerator
	{
		public static int RandomNumberGenerator(int start, int end)
		{
			Random random = new();

			return random.Next(start, end + 1);
		}
	}
}

