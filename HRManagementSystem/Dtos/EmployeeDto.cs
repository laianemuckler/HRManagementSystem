namespace HRManagementSystem.Dtos
{
    public record EmployeeDto
    {
        public Guid Id { get; init; }
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string Email { get; init; }
        public int ContractId { get; init; }
        public DateTimeOffset CreatedDate { get; init; }
    }
}
