using CleanArchMVC.Domain.Validacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMVC.Domain.Entidades
{
    public sealed class Categoria : EntidadeBase
    {
        public string Name { get; private set; }

        public Categoria(string name)
        {
            ValidacaoDominio(name);
            Name = name;
        }


        public Categoria(int id,string name)
        {
            ValidacoesExcecaoDominio.Quando(id < 0, "Id inválido");
            Id = id;
            ValidacaoDominio(name);
        }

        public void Atualizar(string name)
        {
            ValidacaoDominio(name);
        }
        public ICollection<Produto> Produtos { get; set; }
        private void ValidacaoDominio(string name)
        {
            ValidacoesExcecaoDominio.Quando(string.IsNullOrEmpty(name), "Nome inválido. Nome é obrigatório");
            ValidacoesExcecaoDominio.Quando(name.Length < 3, "Nome não pode ser menor que 3 caracteres.");
            Name = name;
        }
    }
}
