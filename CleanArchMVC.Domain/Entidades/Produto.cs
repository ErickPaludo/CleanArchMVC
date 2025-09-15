using CleanArchMVC.Domain.Validacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMVC.Domain.Entidades
{
    public sealed class Produto : EntidadeBase  
    {
        public string Name { get; private set; }
        public string Descricao { get; private set; }
        public decimal Preco { get; private set; }
        public int Estoque { get; private set; }
        public string Imagem { get; private set; }

        public Produto(string name, string descricao, decimal preco, int estoque, string imagem)
        {
            ValidateDomain(name,descricao, preco, estoque, imagem);
        }

        public Produto(int id,string name, string descricao, decimal preco, int estoque, string imagem)
        {
            ValidacoesExcecaoDominio.Quando(id < 0, "Id inválido");
            Id = id;
            ValidateDomain(name,descricao, preco, estoque, imagem);
        }

        private void ValidateDomain(string name, string descricao, decimal preco, int estoque, string imagem)
        {
            ValidacoesExcecaoDominio.Quando(string.IsNullOrEmpty(name), "Nome inválido. Nome é obrigatório");
            ValidacoesExcecaoDominio.Quando(name.Length < 3, "Nome não pode ser menor que 3 caracteres.");
            ValidacoesExcecaoDominio.Quando(string.IsNullOrEmpty(descricao), "Descrição inválida. Descrição é obrigatória");
            ValidacoesExcecaoDominio.Quando(descricao.Length < 5, "Descrição não pode ser menor que 5 caracteres.");
            ValidacoesExcecaoDominio.Quando(preco < 0, "Preço inválido.");
            ValidacoesExcecaoDominio.Quando(estoque < 0, "Estoque inválido.");
            ValidacoesExcecaoDominio.Quando(imagem?.Length > 250, "Nome da imagem não pode ser maior que 250 caracteres.");
            Name = name;
            Descricao = descricao;
            Preco = preco;
            Estoque = estoque;
            Imagem = imagem;
        }

        public void Update(string name, string descricao, decimal preco, int estoque, string imagem,int categoriaId)
        {
            ValidateDomain(name, descricao, preco, estoque, imagem);
            CategoriaId = categoriaId;
        }

        public int CategoriaId { get; private set; }
        public Categoria Categoria { get; set; }
    }
}
