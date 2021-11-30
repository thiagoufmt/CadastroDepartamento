using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCRUD.Models
{
    public class VendasFormViewModel
    {
        public Vendedor Vendedor { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}