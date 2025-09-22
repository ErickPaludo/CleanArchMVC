using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMVC.Application.DTOs
{
    public class ProdutosDTO
    {
        public int Id { get; protected set; }

        public string Name { get; private set; }
        public string Descricao { get; private set; }
        public decimal Preco { get; private set; }
        public int Estoque { get; private set; }
        public string Imagem { get; private set; }
    }
}
