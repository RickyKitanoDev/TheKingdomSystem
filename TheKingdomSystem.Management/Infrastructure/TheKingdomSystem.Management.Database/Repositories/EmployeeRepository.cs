using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKingdomSystem.Management.Database.DatabaseContext;
using TheKingdomSystem.Management.Domain.Entities;
using TheKingdomSystem.Management.Domain.Interfaces;

namespace TheKingdomSystem.Management.Database.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public EmployeeRepository(ManagementDataContext context)
        {
            _context = context;
        }
        private readonly ManagementDataContext _context;
        public Task<Employee> GetAddressById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Employee>> GetAllEmployee()
        {
            var employees = _context.Employee.Include(p => p.JobTitle).Include(p => p.Address).ToList();           
            return await Task.FromResult(employees);
        }

        public async Task SaveEmployee(Employee employee)
        {
            await _context.Employee.AddAsync(employee);
            await _context.SaveChangesAsync();


        }
    }
}
