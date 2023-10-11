namespace CSharpGames.NumberGuesser
{
    public class RandomGenerator
	{
        public static int? GetRandomNumber()
        {
            Interface.DisplayMessage("Please enter a minimum number");
            string? minString = Console.ReadLine();

            Interface.DisplayMessage("Please enter a maximum number");
            string? maxString = Console.ReadLine();

            if (!string.IsNullOrEmpty(minString) && !string.IsNullOrEmpty(maxString) &&
                int.TryParse(minString, out int minInt) && int.TryParse(maxString, out int maxInt) && minInt < maxInt)
            {
                int randomNumber = new Random().Next(minInt, maxInt + 1);
                return randomNumber;
            }
            else
            {
                Interface.DisplayMessage("Invalid input. Minimum must be less than maximum.");
                return null;
            }
        }
    }
}

