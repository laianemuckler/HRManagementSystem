using HRManagementSystem.Dtos;
using HRManagementSystem.Entities;

namespace HRManagementSystem
{
    public static class Extensions
    {
        public static EmployeeDto AsDto(this Employee employee)
        {
            return new EmployeeDto
            {
                Id = employee.Id,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Email = employee.Email,
                ContractId = employee.ContractId,
                CreatedDate = employee.CreateDate
            };
        }
    }
}
