using Newtonsoft.Json;
using DotNetEnv;

namespace CSharpGames.Hangman
{
	public class GetWord
	{
		public static async Task<string?> GetRandomWordAsync()
		{
			Env.Load();
			var apiKey = Environment.GetEnvironmentVariable("API_KEY");

			if (!string.IsNullOrEmpty(apiKey))
			{
                string? randomWord = await GetWordFromApi(apiKey);

				if (!string.IsNullOrEmpty(randomWord))
					return randomWord;

				Interface.DisplayError("No word recieved");
				return null;
				
            }

			Interface.DisplayError("No API key found");
			return null;
        }

		static async Task<string?> GetWordFromApi(string key)
		{
			using (HttpClient client = new())
			{
				client.DefaultRequestHeaders.Add("X-RapidAPI-Key", key);
				client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "wordsapiv1.p.rapidapi.com");

				HttpResponseMessage response = await client.GetAsync($"https://wordsapiv1.p.rapidapi.com/words?random=true");

				if (response.IsSuccessStatusCode)
				{
					string content = await response.Content.ReadAsStringAsync();
					
					ApiResponse apiResponse = JsonConvert.DeserializeObject<ApiResponse>(content);
					string randomWord = apiResponse.Word;

					return randomWord;
				}
				else
				{
					Interface.DisplayError("Error fetching words: " + response.ReasonPhrase);
					return null;
				}
			}
		}
	}
}


public class ApiResponse
{
    public required string Word { get; set; }
}