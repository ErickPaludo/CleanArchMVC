using CleanArchMVC.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMVC.Domain.Interfaces
{
    public interface IProdutoRepositorio
    {
        Task<IEnumerable<Produto>> GetProdutos();
        Task<Produto> GetById(int? id);
        Task Create(Produto produto);
        Task Update(Produto produto);
        Task Remove(Produto produto);
    }
}
