using AutoMapper;
using CleanArchMvc.Application.Interfaces;
using CleanArchMVC.Application.DTOs;
using CleanArchMVC.Domain.Entidades;
using CleanArchMVC.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchMvc.Application.Services
{
    public class ProdutoServico : IProdutoServico
    {
        private IProdutoRepositorio _productRepository;

        private readonly IMapper _mapper;
        public ProdutoServico(IMapper mapper, IProdutoRepositorio productRepository)
        {
            _productRepository = productRepository ??
                 throw new ArgumentNullException(nameof(productRepository));

            _mapper = mapper;
        }

        public async Task Remove(int? id)
        {
            var productEntity = _productRepository.GetById(id).Result;
            await _productRepository.Remove(productEntity);
        }

        public async Task<IEnumerable<ProdutosDTO>> GetProducts()
        {
            var productsEntity = await _productRepository.GetProdutos();
            return _mapper.Map<IEnumerable<ProdutosDTO>>(productsEntity);
        }

        public async Task<ProdutosDTO> GetById(int? id)
        {
            var productEntity = await _productRepository.GetById(id);
            return _mapper.Map<ProdutosDTO>(productEntity);
        }

        public async Task<ProdutosDTO> GetProductCategory(int? id)
        {
            var productEntity = await _productRepository.GetById(id);
            return _mapper.Map<ProdutosDTO>(productEntity);
        }

        public async Task Add(ProdutosDTO productDto)
        {
            var productEntity = _mapper.Map<Produto>(productDto);
            await _productRepository.Create(productEntity);
        }

        public async Task Update(ProdutosDTO productDto)
        {
            var productEntity = _mapper.Map<Produto>(productDto);
            await _productRepository.Update(productEntity);
        }
    }
}
