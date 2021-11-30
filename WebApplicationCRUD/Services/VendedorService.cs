using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationCRUD.Data;
using WebApplicationCRUD.Models;
using Microsoft.EntityFrameworkCore;
using WebApplicationCRUD.Services.Exception;

namespace WebApplicationCRUD.Services
{
    public class VendedorService
    {
        private readonly WebApplicationCRUDContext _context;
        public VendedorService(WebApplicationCRUDContext context)
        {
            _context = context;
        }
        public async Task<List<Vendedor>> FindAllAsync()
        {
            return await _context.Vendedors.ToListAsync();
        }
        public async Task InsertAsync(Vendedor obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Vendedor> FindByIdAsync(int id)
        {
            //return _context.Vendedors.FirstOrDefault(obj => obj.Id == id);
            return await _context.Vendedors.Include(obj => obj.Department).FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Vendedors.FindAsync(id);
                _context.Vendedors.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException("Can't delete seller because he/she has sales");
            }
        }
        public async Task UpdateAsync(Vendedor obj)
        {
            bool hasAny = await _context.Vendedors.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny)
            {
                throw new Exception.NotFoundException("Id not found");
            }
            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbUpdateConcurrencyException(e.Message);
            }
        }
    }
}