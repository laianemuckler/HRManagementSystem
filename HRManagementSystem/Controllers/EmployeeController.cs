using HRManagementSystem.Dtos;
using HRManagementSystem.Entities;
using HRManagementSystem.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRManagementSystem.Controllers
{
    
    [ApiController]
    [Route("employees")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository repository;

        public EmployeeController(IEmployeeRepository repository)
        {
            this.repository = repository;
        }

        // GET /employees
        [HttpGet]
        public IEnumerable<EmployeeDto> GetEmployees()
        {
            var employees = repository.GetEmployees().Select(employee => employee.AsDto());
            return employees;
        }

        // GET /employees/{id}
        [HttpGet("{id}")]
        public ActionResult<EmployeeDto> GetEmployee(Guid id)
        {
            var employee = repository.GetEmployee(id);
            if(employee is null)
            {
                return NotFound();
            }
            return employee.AsDto();
        }

        // POST /employees
        [HttpPost]
        public ActionResult<EmployeeDto> CreateEmployee(CreateEmployeeDto itemDto)
        {
            Employee employee = new()
            {
                Id = Guid.NewGuid(),
                FirstName = itemDto.FirstName,
                LastName = itemDto.LastName,
                Email = itemDto.Email,
                ContractId = itemDto.ContractId,
                CreateDate = DateTimeOffset.UtcNow
            };

            repository.CreateEmployee(employee);

            return CreatedAtAction(nameof(GetEmployee), new { id = employee.Id }, employee.AsDto());

        }

        // PUT /items/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateEmployee(Guid id, UpdateEmployeeDto employeeDto)
        {
            var existingEmployee = repository.GetEmployee(id);

            if(existingEmployee is null)
            {
                return NotFound();
            }

            Employee updatedEmployee = existingEmployee with
            {
                FirstName = employeeDto.FirstName,
                LastName = employeeDto.LastName,
                Email = employeeDto.Email,
                ContractId = employeeDto.ContractId,
            };

            repository.UpdateEmployee(updatedEmployee);

            return NoContent();
        }

        // DELETE /employees/{id}
        [HttpDelete]
        public ActionResult DeleteEmployee(Guid id)
        {
            var existingEmployee = repository.GetEmployee(id);
            if (existingEmployee is null)
            {
                return NotFound();
            }

            repository.DeleteEmployee(id);

            return NoContent();

        }

    }
}
