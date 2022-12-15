using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net.Http;
namespace ChatGPT
{
    public class OpenAiClient
    {
        private readonly HttpClient _httpClient;

        public OpenAiClient(string apiKey)
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
        }

        public async Task<Response> SendRequest(string prompt, string model, int maxTokens, bool echo)
        {
            var requestParams = new
            {
                prompt = prompt,
                model = model,
                max_tokens = maxTokens,
                echo = echo,
            };

            var requestJson = JsonSerializer.Serialize(requestParams);
            var requestContent = new StringContent(requestJson, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("https://api.openai.com/v1/completions", requestContent);

            if (await response.Content.ReadAsStringAsync() is string responseJson)
            {
                return JsonSerializer.Deserialize<Response>(responseJson);
            }

            return null;
        }
    }

}
