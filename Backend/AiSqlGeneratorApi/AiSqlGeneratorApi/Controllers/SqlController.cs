using Microsoft.AspNetCore.Mvc;
using AiSqlGeneratorApi.DTOs;
using AiSqlGeneratorApi.Interfaces;

namespace AiSqlGeneratorApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SqlController : ControllerBase
    {
        private readonly ISqlGeneratorService _sqlService;

        public SqlController(ISqlGeneratorService sqlService)
        {
            _sqlService = sqlService;
        }

        [HttpPost("generate")]
        public async Task<IActionResult> GenerateSql([FromBody] SqlRequestDto request)
        {
            if (string.IsNullOrEmpty(request.UserInput))
            {
                return BadRequest("Input cannot be empty");
            }

            var result = await _sqlService.GenerateSqlAsync(request);

            return Ok(result);
        }
    }
}