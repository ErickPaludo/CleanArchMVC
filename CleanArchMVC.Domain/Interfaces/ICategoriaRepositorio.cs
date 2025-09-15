using CleanArchMVC.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMVC.Domain.Interfaces
{
    public interface ICategoriaRepositorio
    {
        Task<IEnumerable<Categoria>> GetCategorias();
        Task<Categoria> GetById(int? id);
        Task Create(Categoria categoria);
        Task Update(Categoria categoria);
        Task Remove(Categoria categoria);
    }
}
