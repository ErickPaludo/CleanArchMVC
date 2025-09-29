using AutoMapper;
using CleanArchMvc.Application.Interfaces;
using CleanArchMVC.Application.DTOs;
using CleanArchMVC.Application.Produtos.Queries;
using CleanArchMVC.Domain.Entidades;
using CleanArchMVC.Domain.Interfaces;
using NetDevPack.SimpleMediator;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchMvc.Application.Services
{
    public class ProdutoServico : IProdutoServico
    {
        private readonly IMediator _mediator;

        private readonly IMapper _mapper;
        public ProdutoServico(IMapper mapper, IMediator mediator)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        public async Task Remove(int? id)
        {
            //var productEntity = _productRepository.GetById(id).Result;
            //await _productRepository.Remove(productEntity);
        }

        public async Task<IEnumerable<ProdutosDTO>> GetProducts()
        {
           var productsQuery = new GetProductsQuery();
            if (productsQuery == null)
                return null;
           var result = await _mediator.Send(productsQuery);
            return _mapper.Map<IEnumerable<ProdutosDTO>>(result);
        }

        public async Task<ProdutosDTO> GetById(int? id)
        {
            //var productEntity = await _productRepository.GetById(id);
            //return _mapper.Map<ProdutosDTO>(productEntity);
            return null;
        }

        public async Task<ProdutosDTO> GetProductCategory(int? id)
        {
            //var productEntity = await _productRepository.GetById(id);
            //return _mapper.Map<ProdutosDTO>(productEntity);
            return null;

        }

        public async Task Add(ProdutosDTO productDto)
        {
            //var productEntity = _mapper.Map<Produto>(productDto);
            //await _productRepository.Create(productEntity);

        }

        public async Task Update(ProdutosDTO productDto)
        {
            //var productEntity = _mapper.Map<Produto>(productDto);
            //await _productRepository.Update(productEntity);
        }
    }
}
