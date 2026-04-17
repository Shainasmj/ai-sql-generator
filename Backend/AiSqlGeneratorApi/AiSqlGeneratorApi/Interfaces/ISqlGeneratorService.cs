using AiSqlGeneratorApi.DTOs;

namespace AiSqlGeneratorApi.Interfaces
{
    public interface ISqlGeneratorService
    {
        Task<SqlResponseDto> GenerateSqlAsync(SqlRequestDto request);
    }
}