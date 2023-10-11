namespace CSharpGames.NumberGuesser
{
    public class Range
	{
		public static int? CheckRange(int start, int end)
		{
			if (start >= end)
				return null;

			return RandomGenerator.RandomNumberGenerator(start, end);
		}
	}
}

