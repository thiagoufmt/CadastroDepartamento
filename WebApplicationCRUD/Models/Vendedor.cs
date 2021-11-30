using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationCRUD.Models
{
    public class Vendedor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} size should be between {2} and {1}")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [EmailAddress(ErrorMessage = "Enter a valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [Range(100.0, 50000.0, ErrorMessage = "{0} must be from {1} to {2}")]
        [Display(Name = "Base Salarial")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double SalarioBase { get; set; }
        
        [Display(Name = "Departamento")]
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public ICollection<RecordeVendas> Vendas { get; set; } = new List<RecordeVendas>();

        public Vendedor()
        {
        }

        public Vendedor(int id, string name, string email, DateTime dataNascimento, double salarioBase, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            DataNascimento = dataNascimento;
            SalarioBase = salarioBase;
            Department = department;
        }

        public void AddVendas(RecordeVendas rv)
        {
            Vendas.Add(rv);
        }

        public void RemoveVendas(RecordeVendas rv)
        {
            Vendas.Remove(rv);
        }

        public double TotalVendas(DateTime initial, DateTime final)
        {
            return Vendas.Where(rv => rv.Data >= initial && rv.Data <= final).Sum(rv => rv.Quantidade);
        }
    }
}
