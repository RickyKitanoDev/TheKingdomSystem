using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKingdomSystem.Management.Domain.Entities;

namespace TheKingdomSystem.Management.Domain.Interfaces
{
    public interface IEmployeeRepository
    {
        Task SaveEmployee(Employee employee);
        Task<List<Employee>> GetAllEmployee();
        Task<Employee> GetAddressById(int id); 
    }
}
