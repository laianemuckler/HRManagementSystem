using HRManagementSystem.Entities;

namespace HRManagementSystem.Repositories
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(Guid id);
        IEnumerable<Employee> GetEmployees();
        void CreateEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(Guid id);
    }
}
