using HRManagementSystem.Dtos;
using HRManagementSystem.Repositories;
using HRManagementSystem.Services.Interfaces;

namespace HRManagementSystem.Services.Services
{
    public class EmployeeService : IEmployeeService
    {

        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public void CreateEmployee(EmployeeDto employee)
        {
            // validações 
            // após validações enviar para o repository
            _employeeRepository.CreateEmployee()
        }

        public void DeleteEmployee(Guid id)
        {
            throw new NotImplementedException();
        }

        public EmployeeDto GetEmployee(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeDto> GetEmployees()
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployee(EmployeeDto employee)
        {
            throw new NotImplementedException();
        }
    }
}
