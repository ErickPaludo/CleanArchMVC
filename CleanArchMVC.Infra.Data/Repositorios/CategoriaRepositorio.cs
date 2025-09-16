using CleanArchMVC.Domain.Entidades;
using CleanArchMVC.Domain.Interfaces;
using CleanArchMVC.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMVC.Infra.Data.Repositorios
{
    public class CategoriaRepositorio : ICategoriaRepositorio
    {
        private readonly ApplicationDbContext _context;
        public CategoriaRepositorio(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task Create(Categoria categoria)
        {
            _context.Add(categoria);
            await _context.SaveChangesAsync();
        }

        public async Task<Categoria> GetById(int? id)
        {
            return await _context.Categorias.FindAsync(id);
        }

        public async Task<IEnumerable<Categoria>> GetCategorias()
        {
           return await _context.Categorias.ToListAsync();
        }

        public async Task<Categoria> Remove(Categoria categoria)
        {
            _context.Remove(categoria);
            await _context.SaveChangesAsync();
            return categoria;
        }

        public async Task Update(Categoria categoria)
        {
            _context.Update(categoria);
            await _context.SaveChangesAsync();
        }
    }
}
