using AiSqlGeneratorApi.Prompts;

namespace AiSqlGeneratorApi.Helpers
{
    public static class PromptBuilder
    {
        public static string BuildPrompt(string userInput)
        {
            return $@"
You are an expert SQL generator.

Convert the given natural language into a SQL query.

Database Schema:
{DatabaseSchema.Schema}

User Request:
{userInput}

Rules:
- Only return SQL query
- No explanation
- Use proper JOINs where needed
";
        }
    }
}