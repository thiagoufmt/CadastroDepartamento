using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationCRUD.Services;
using WebApplicationCRUD.Data;
using WebApplicationCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationCRUD.Services
{
    public class RecordVendasService
    {
        private readonly WebApplicationCRUDContext _context;

        public RecordVendasService(WebApplicationCRUDContext context)
       
        {
            _context = context;
        }

        public async Task<List<RecordeVendas>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.RecordeVendas select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Data >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Data <= maxDate.Value);
            }
            return await result
                .Include(x => x.Vendedor)
                .Include(x => x.Vendedor.Department)
                .OrderByDescending(x => x.Data)
                .ToListAsync();
        }

        public async Task<List<IGrouping<Department,RecordeVendas>>> FindByDateGroupingAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.RecordeVendas select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Data >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Data <= maxDate.Value);
            }
            var retornoSales = await result
             .Include(x => x.Vendedor)
             .Include(x => x.Vendedor.Department)
             .OrderByDescending(x => x.Data)
             .ToListAsync();
            return retornoSales.GroupBy(x => x.Vendedor.Department).ToList();
        }
    }
}
