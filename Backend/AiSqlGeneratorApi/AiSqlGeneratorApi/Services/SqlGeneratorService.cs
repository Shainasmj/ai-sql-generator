using AiSqlGeneratorApi.DTOs;
using AiSqlGeneratorApi.Interfaces;
using AiSqlGeneratorApi.Helpers;
using System.Text;
using System.Text.Json;

namespace AiSqlGeneratorApi.Services
{
    public class SqlGeneratorService : ISqlGeneratorService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public SqlGeneratorService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task<SqlResponseDto> GenerateSqlAsync(SqlRequestDto request)
        {
            var apiKey = _configuration["OpenRouter:ApiKey"];

            var prompt = PromptBuilder.BuildPrompt(request.UserInput);

            var requestBody = new
            {
                model = "openai/gpt-3.5-turbo",
                messages = new[]
                {
                    new { role = "user", content = prompt }
                }
            };

            var json = JsonSerializer.Serialize(requestBody);

            var requestMessage = new HttpRequestMessage(
                HttpMethod.Post,
                "https://openrouter.ai/api/v1/chat/completions"
            );

            requestMessage.Headers.Add("Authorization", $"Bearer {apiKey}");
            requestMessage.Headers.Add("HTTP-Referer", "http://localhost");

            requestMessage.Content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.SendAsync(requestMessage);

            var responseContent = await response.Content.ReadAsStringAsync();

            Console.WriteLine("OPENROUTER RESPONSE:");
            Console.WriteLine(responseContent);

            using var doc = JsonDocument.Parse(responseContent);

            
            if (!doc.RootElement.TryGetProperty("choices", out var choices))
            {
                return new SqlResponseDto
                {
                    GeneratedSql = "ERROR FROM AI: " + responseContent
                };
            }

            var sql = choices[0]
                .GetProperty("message")
                .GetProperty("content")
                .GetString();

            return new SqlResponseDto
            {
                GeneratedSql = sql
            };
        }
    }
}