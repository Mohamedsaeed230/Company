﻿using Company.BLL.Interfaces;
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
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {


        public DepartmentRepository(AppDbContext context) : base(context)//Ask Clr Create Object From AppDbContext
        {

        }
    }
}
