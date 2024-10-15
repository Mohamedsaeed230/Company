using Company.BLL.Interfaces;
using Company.DAL.Data.Contexts;
using Company.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.BLL.Repositories
{
    public class DependentRepository : GenericRepository<Dependent>, IDependentRepository
    {
        public DependentRepository(AppDbContext context) : base(context)
        {

        }
    }
}
