using Company.BLL.Interfaces;
using Company.BLL.Repositories;
using Company.DAL.Data.Contexts;
using Company.DAL.Models;
using Company.BLL.Interfaces;
using Company.DAL.Data.Contexts;
using Company.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.BLL.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(AppDbContext _context) : base(_context)
        {

        }

        public async Task<IEnumerable<Employee>> GetByNameAsync(string name) // Search
        {
            return await _context.Employees.Where(E => E.Name.ToLower().Contains(name.ToLower())).Include(E => E.WorkFor).ToListAsync();
        }
    }
}
