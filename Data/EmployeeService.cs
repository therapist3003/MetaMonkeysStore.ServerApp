using MetaMonkeysStore.ServerApp.Context;
using Microsoft.EntityFrameworkCore;

namespace MetaMonkeysStore.ServerApp.Data
{
    public class EmployeeService
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public EmployeeService(ApplicationDbContext applicationDbContext) 
        {
            _applicationDbContext = applicationDbContext;
        }


        // Get All Employees
        public async Task<List<Employee>> GetAllEmployes()
        {
            return await _applicationDbContext.Employees.ToListAsync();
        }

        public async Task<bool> AddNewEmployee(Employee employee)
        {
            await _applicationDbContext.Employees.AddAsync(employee);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        //Get Employee Record By username
        public async Task<Employee> GetEmployeeByUsername(string uname)
        {
            Employee employee = await _applicationDbContext.Employees.FirstOrDefaultAsync(x => x.Username == uname);
            return employee;
        }
    }
}
