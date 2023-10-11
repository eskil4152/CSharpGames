using Newtonsoft.Json;

namespace CSharpGames.Hangman
{
	public class GetWord
	{
		public static async Task GetRandomWordAsync()
		{
			var apiKey = "";
			var difficulty = "easy";

			Task<string> wordTask = GetWordFromApi(apiKey, difficulty);

			string randomWord = await GetWordFromApi(apiKey, difficulty);
			Console.WriteLine("Random word: " + randomWord);
		}

		static async Task<string> GetWordFromApi(string key, string difficulty)
		{
			using (HttpClient client = new())
			{
				client.DefaultRequestHeaders.Add("X-RapidAPI-Key", key);
				client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "wordsapiv1.p.rapidapi.com");

				HttpResponseMessage response = await client.GetAsync($"https://wordsapiv1.p.rapidapi.com/words/?difficulty={difficulty}");

				if (response.IsSuccessStatusCode)
				{
					string content = await response.Content.ReadAsStringAsync();
					ApiResponse apiResponse = JsonConvert.DeserializeObject<ApiResponse>(content);
					List<string> words = apiResponse.Results.Data;
					Random random = new Random();
					string randomWord = words[random.Next(words.Count)];

					return randomWord;
				}
				else
				{
					Console.WriteLine("Error fetching words: " + response.ReasonPhrase);
					return null;
				}
			}
		}
	}
}

public class ApiResponse
{
	public required Query Query { get; set; }
	public required Results Results { get; set; }
}

public class Query
{
    public int Limit { get; set; }
    public int Page { get; set; }
}

public class Results
{
    public int Total { get; set; }
    public required List<string> Data { get; set; }
}