namespace AiSqlGeneratorApi.Prompts
{
    public static class DatabaseSchema
    {
        public static string Schema = @"
Tables:

Employees:
- Id (int)
- Name (varchar)
- DepartmentId (int)
- Salary (decimal)

Departments:
- Id (int)
- DepartmentName (varchar)

Rules:
- Employees.DepartmentId references Departments.Id
";
    }
}