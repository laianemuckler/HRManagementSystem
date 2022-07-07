using System.ComponentModel.DataAnnotations;

namespace HRManagementSystem.Dtos
{
    public record UpdateEmployeeDto
    {
        [Required]
        public string FirstName { get; init; }
        [Required]
        public string LastName { get; init; }
        public string Email { get; init; }
        public int ContractId { get; init; }

    }
}
