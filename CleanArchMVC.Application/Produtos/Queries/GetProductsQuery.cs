using CleanArchMVC.Domain.Entidades;
using NetDevPack.SimpleMediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMVC.Application.Produtos.Queries
{
    public class GetProductsQuery : IRequest<IEnumerable<Produto>>
    {
    }
}
