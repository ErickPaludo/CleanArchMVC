using CleanArchMVC.Application.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchMvc.Application.Interfaces
{
    public interface IProdutoServico
    {
        Task<IEnumerable<ProdutosDTO>> GetProducts();
        Task<ProdutosDTO> GetById(int? id);

        Task<ProdutosDTO> GetProductCategory(int? id);
        Task Add(ProdutosDTO productDto);
        Task Update(ProdutosDTO productDto);
        Task Remove(int? id);
    }
}
