namespace HRManagementSystem.Entities
{
    public record Employee
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int ContractId { get; set; }
        public DateTimeOffset CreateDate { get; set; }

    }
}
