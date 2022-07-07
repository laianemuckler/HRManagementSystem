using HRManagementSystem.Dtos;
using HRManagementSystem.Entities;

namespace HRManagementSystem.Services.Interfaces
{
    public interface IEmployeeService
    {
        EmployeeDto GetEmployee(Guid id);
        IEnumerable<EmployeeDto> GetEmployees();
        void CreateEmployee(EmployeeDto employee);
        void UpdateEmployee(EmployeeDto employee);
        void DeleteEmployee(Guid id);
    }
}
