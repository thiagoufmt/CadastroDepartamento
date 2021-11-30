using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationCRUD.Data;
using WebApplicationCRUD.Models;
using WebApplicationCRUD.Models.Enums;

namespace WebApplicationCRUD.Data
{
    public class SeedingService
    {
        private WebApplicationCRUDContext _context;

        public SeedingService(WebApplicationCRUDContext context)
        {
            _context = context;
        }

        public void Seed()
        { 
            if (_context.Department.Any() ||
                _context.Vendedors.Any() ||
                _context.RecordeVendas.Any())
            {
                return; // Banco de dados já populado
            }
            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Vendedor s1 = new Vendedor(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Vendedor s2 = new Vendedor(2, "Maria Green", "maria@gmail.com", new DateTime(1979, 12, 31), 3500.0, d2);
            Vendedor s3 = new Vendedor(3, "Alex Grey", "alex@gmail.com", new DateTime(1988, 1, 15), 2200.0, d1);
            Vendedor s4 = new Vendedor(4, "Martha Red", "martha@gmail.com", new DateTime(1993, 11, 30), 3000.0, d4);
            Vendedor s5 = new Vendedor(5, "Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9), 4000.0, d3);
            Vendedor s6 = new Vendedor(6, "Alex Pink", "bob@gmail.com", new DateTime(1997, 3, 4), 3000.0, d2);

            RecordeVendas r1 = new RecordeVendas(1, new DateTime(2018, 09, 25), 11000.0, StatusVendas.Faturad, s1);
            RecordeVendas r2 = new RecordeVendas(2, new DateTime(2018, 09, 4), 7000.0, StatusVendas.Faturad, s5);
            RecordeVendas r3 = new RecordeVendas(3, new DateTime(2018, 09, 13), 4000.0, StatusVendas.Cancelado, s4);
            RecordeVendas r4 = new RecordeVendas(4, new DateTime(2018, 09, 1), 8000.0, StatusVendas.Faturad, s1);
            RecordeVendas r5 = new RecordeVendas(5, new DateTime(2018, 09, 21), 3000.0, StatusVendas.Faturad, s3);
            RecordeVendas r6 = new RecordeVendas(6, new DateTime(2018, 09, 15), 2000.0, StatusVendas.Faturad, s1);
            RecordeVendas r7 = new RecordeVendas(7, new DateTime(2018, 09, 28), 13000.0, StatusVendas.Faturad, s2);
            RecordeVendas r8 = new RecordeVendas(8, new DateTime(2018, 09, 11), 4000.0, StatusVendas.Faturad, s4);
            RecordeVendas r9 = new RecordeVendas(9, new DateTime(2018, 09, 14), 11000.0, StatusVendas.Pendente, s6);
            RecordeVendas r10 = new RecordeVendas(10, new DateTime(2018, 09, 7), 9000.0, StatusVendas.Faturad, s6);
            RecordeVendas r11 = new RecordeVendas(11, new DateTime(2018, 09, 13), 6000.0, StatusVendas.Faturad, s2);
            RecordeVendas r12 = new RecordeVendas(12, new DateTime(2018, 09, 25), 7000.0, StatusVendas.Pendente, s3);
            RecordeVendas r13 = new RecordeVendas(13, new DateTime(2018, 09, 29), 10000.0, StatusVendas.Faturad, s4);
            RecordeVendas r14 = new RecordeVendas(14, new DateTime(2018, 09, 4), 3000.0, StatusVendas.Faturad, s5);
            RecordeVendas r15 = new RecordeVendas(15, new DateTime(2018, 09, 12), 4000.0, StatusVendas.Faturad, s1);
            RecordeVendas r16 = new RecordeVendas(16, new DateTime(2018, 10, 5), 2000.0, StatusVendas.Faturad, s4);
            RecordeVendas r17 = new RecordeVendas(17, new DateTime(2018, 10, 1), 12000.0, StatusVendas.Faturad, s1);
            RecordeVendas r18 = new RecordeVendas(18, new DateTime(2018, 10, 24), 6000.0, StatusVendas.Faturad, s3);
            RecordeVendas r19 = new RecordeVendas(19, new DateTime(2018, 10, 22), 8000.0, StatusVendas.Faturad, s5);
            RecordeVendas r20 = new RecordeVendas(20, new DateTime(2018, 10, 15), 8000.0, StatusVendas.Faturad, s6);
            RecordeVendas r21 = new RecordeVendas(21, new DateTime(2018, 10, 17), 9000.0, StatusVendas.Faturad, s2);
            RecordeVendas r22 = new RecordeVendas(22, new DateTime(2018, 10, 24), 4000.0, StatusVendas.Faturad, s4);
            RecordeVendas r23 = new RecordeVendas(23, new DateTime(2018, 10, 19), 11000.0, StatusVendas.Cancelado, s2);
            RecordeVendas r24 = new RecordeVendas(24, new DateTime(2018, 10, 12), 8000.0, StatusVendas.Faturad, s5);
            RecordeVendas r25 = new RecordeVendas(25, new DateTime(2018, 10, 31), 7000.0, StatusVendas.Faturad, s3);
            RecordeVendas r26 = new RecordeVendas(26, new DateTime(2018, 10, 6), 5000.0, StatusVendas.Faturad, s4);
            RecordeVendas r27 = new RecordeVendas(27, new DateTime(2018, 10, 13), 9000.0, StatusVendas.Pendente, s1);
            RecordeVendas r28 = new RecordeVendas(28, new DateTime(2018, 10, 7), 4000.0, StatusVendas.Faturad, s3);
            RecordeVendas r29 = new RecordeVendas(29, new DateTime(2018, 10, 23), 12000.0, StatusVendas.Faturad, s5);
            RecordeVendas r30 = new RecordeVendas(30, new DateTime(2018, 10, 12), 5000.0, StatusVendas.Faturad, s2);

            _context.Department.AddRange(d1, d2, d3, d4);

            _context.Vendedors.AddRange(s1, s2, s3, s4, s5, s6);

            _context.RecordeVendas.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30
            );

            _context.SaveChanges();
        }
       
    }
}
