using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationCRUD.Models;

namespace WebApplicationCRUD.Data
//namespace WebApplicationCRUD.Models
{
    public class WebApplicationCRUDContext : DbContext
    {
        public WebApplicationCRUDContext (DbContextOptions<WebApplicationCRUDContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationCRUD.Models.Department> Department { get; set; }
        public DbSet<WebApplicationCRUD.Models.Vendedor> Vendedors { get; set; }
        public DbSet<WebApplicationCRUD.Models.RecordeVendas> RecordeVendas { get; set; }
        //public DbSet<Department> Department { get; set; }
        //public DbSet<Vendedor> Vendedor { get; set; }
        // public DbSet<RecordeVendas> RecordeVendas { get; set; }

    }
}
