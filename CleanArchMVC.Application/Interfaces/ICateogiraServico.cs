using CleanArchMVC.Application.DTOs;
using CleanArchMVC.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMVC.Application.Interfaces
{
    public interface ICateogiraServico
    {
        Task<IEnumerable<CategoriaDTO>> GetCategoriasAsync();
        Task<CategoriaDTO> GetByIdAsync(int? id);
        Task Add(CategoriaDTO categoriaDTO);
        Task Update(CategoriaDTO categoriaDTO);
        Task Remove(int? id);
    }
}
