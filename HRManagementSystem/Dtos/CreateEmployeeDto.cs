using System.ComponentModel.DataAnnotations;

namespace HRManagementSystem.Dtos
{
    public record CreateEmployeeDto
    {
        [Required]
        public string FirstName { get; init; }
        [Required]
        public string LastName { get; init; }
        public string Email { get; init; }
        [Required]
        public int ContractId { get; init; }

    }
}
