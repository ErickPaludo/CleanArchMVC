using AutoMapper;
using CleanArchMVC.Application.DTOs;
using CleanArchMVC.Application.Interfaces;
using CleanArchMVC.Domain.Entidades;
using CleanArchMVC.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMVC.Application.Servicos
{
    public class CategoriaServico : ICategoriaServico
    {
        private ICategoriaRepositorio _categoriaRepositorio;
        private readonly IMapper _mapper;
        public CategoriaServico(ICategoriaRepositorio categoriaRepositorio, IMapper mapper)
        {
            _categoriaRepositorio = categoriaRepositorio;
            _mapper = mapper;
        }
        public async Task<IEnumerable<CategoriaDTO>> GetCategoriasAsync()
        {
            var categoriaEntidades = await _categoriaRepositorio.GetCategorias();
            return _mapper.Map<IEnumerable<CategoriaDTO>>(categoriaEntidades);
        }
        public async Task<CategoriaDTO> GetByIdAsync(int? id)
        {
            var categoriaEntidade = await _categoriaRepositorio.GetById(id);
            return _mapper.Map<CategoriaDTO>(categoriaEntidade);
        }
        public async Task Add(CategoriaDTO categoriaDTO)
        {
            var categoriaEntidade = _mapper.Map<Categoria>(categoriaDTO);
            await _categoriaRepositorio.Create(categoriaEntidade);
        }
        public async Task Update(CategoriaDTO categoriaDTO)
        {
            var categoriaEntidade = _mapper.Map<Categoria>(categoriaDTO);
            await _categoriaRepositorio.Remove(categoriaEntidade);
        }
        public async Task Remove(int? id)
        {
            var categoriaEntidade = _categoriaRepositorio.GetById(id).Result;
            await _categoriaRepositorio.Remove(categoriaEntidade);
        }

    }
}
