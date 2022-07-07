using HRManagementSystem.Entities;

namespace HRManagementSystem.Repositories
{
    public class InMemoryEmployeeRepository : IEmployeeRepository
    {
        private readonly List<Employee> employees = new()
        {
            new Employee { Id = Guid.NewGuid(), FirstName = "Maria", LastName = "Silva", Email = "maria.silva@programmmers.com.br", ContractId = 1, CreateDate = DateTimeOffset.UtcNow },
            new Employee { Id = Guid.NewGuid(), FirstName = "José", LastName = "Lima", Email = "jose.lima@programmers.com.br", ContractId = 2, CreateDate = DateTimeOffset.UtcNow },
            new Employee { Id = Guid.NewGuid(), FirstName = "Carlos", LastName = "Santana", Email = "carlos.santana@programmers.com.br", ContractId = 2, CreateDate = DateTimeOffset.UtcNow }
        };

        public IEnumerable<Employee> GetEmployees()
        {
            return employees;
        }

        public Employee GetEmployee(Guid id)
        {
            return employees.Where(employee => employee.Id == id).SingleOrDefault();
        }

        public void CreateEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void UpdateEmployee(Employee employee)
        {
            var index = employees.FindIndex(existingEmployee => existingEmployee.Id == employee.Id);
            employees[index] = employee;
        }

        public void DeleteEmployee(Guid id)
        {
            var index = employees.FindIndex(existingEmployee => existingEmployee.Id == id);
            employees.RemoveAt(index);
        }
    }
}
