using System;
using System.Collections.Generic;
using System.Linq;
namespace WebApplicationCRUD.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Vendedor> Vendedors { get; set; } = new List<Vendedor>();

        public Department()
            {

            }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public void AddVendedor(Vendedor vendedor) 
        {
            Vendedors.Add(vendedor);
        
        }

        public double TotalVendas(DateTime initial, DateTime final)
        {
            return Vendedors.Sum(vendedor => vendedor.TotalVendas(initial, final));
        }
    }
}
