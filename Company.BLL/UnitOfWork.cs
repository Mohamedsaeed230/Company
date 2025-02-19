﻿using Company.BLL.Interfaces;
using Company.BLL.Repositories;
using Company.DAL.Data.Contexts;
using Company.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.BLL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IDependentRepository _dependentRepository;
        private readonly IProjectRepository _projectRepository;
        private readonly AppDbContext _dbContext;

        public UnitOfWork(AppDbContext dbContext)
        {
            _employeeRepository = new EmployeeRepository(dbContext);
            _departmentRepository = new DepartmentRepository(dbContext);
            _dependentRepository = new DependentRepository(dbContext);
            _projectRepository = new ProjectRepository(dbContext);
            _dbContext = dbContext;
        }

        public IDepartmentRepository DepartmentRepository => _departmentRepository;

        public IEmployeeRepository EmployeeRepository => _employeeRepository;

        public IDependentRepository DependentRepository => _dependentRepository;

        public IProjectRepository ProjectRepository => _projectRepository;

        public async Task<int> CompleteAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }
    }

}
