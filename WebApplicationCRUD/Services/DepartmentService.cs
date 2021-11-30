﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationCRUD.Data;
using WebApplicationCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationCRUD.Services
{
    public class DepartmentService
    {
        private readonly WebApplicationCRUDContext _context;

        public DepartmentService(WebApplicationCRUDContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}