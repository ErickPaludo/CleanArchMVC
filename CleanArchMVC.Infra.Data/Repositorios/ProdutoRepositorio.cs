using CleanArchMVC.Domain.Entidades;
using CleanArchMVC.Domain.Interfaces;
using CleanArchMVC.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CleanArchMVC.Infra.Data.Repositorios
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly ApplicationDbContext _context;
        public ProdutoRepositorio(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task Create(Produto produto)
        {
            _context.Add(produto);
            await _context.SaveChangesAsync();
        }

        public async Task<Produto> GetById(int? id)
        {
            //Carregamento adiantado
            return await _context.Produtos.Include(c => c.CategoriaId).SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Produto>> GetProdutos()
        {
            return await _context.Produtos.ToListAsync();
        }

        public async Task<Produto> Remove(Produto produto)
        {
            _context.Remove(produto);
            await _context.SaveChangesAsync();
            return produto;
        }

        public async Task Update(Produto produto)
        {
            _context.Update(produto);
            await _context.SaveChangesAsync();
        }
    }
}
