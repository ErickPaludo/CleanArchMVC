using CleanArchMVC.Application.Produtos.Queries;
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
    public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, IEnumerable<Produto>>
    {
        private readonly IProdutoRepositorio _produtoRepositorio;
        public GetProductsQueryHandler(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }
        public async Task<IEnumerable<Produto>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            return await _produtoRepositorio.GetProdutos();
        }
    }
}
