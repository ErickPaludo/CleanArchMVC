using CleanArchMVC.Application.Produtos.Comandos;
using CleanArchMVC.Domain.Entidades;
using CleanArchMVC.Domain.Interfaces;
using NetDevPack.SimpleMediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMVC.Application.Produtos.Handlers
{
    public class ProductCreateCommandHandler : IRequestHandler<ProductCreateCommand, Produto>
    {
        private readonly IProdutoRepositorio _produtoRepositorio;
        public ProductCreateCommandHandler(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }
        public async Task<Produto> Handle(ProductCreateCommand request, CancellationToken cancellationToken)
        {
            var produto = new Produto(request.Name, request.Descricao, request.Preco, request.Estoque,request.Imagem);
            produto.CategoriaId = request.CategoriaId;
            await _produtoRepositorio.Create(produto);
            return produto;
        }
    }
}
