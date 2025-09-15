using CleanArchMVC.Domain.Entidades;
using CleanArchMVC.Domain.Validacoes;
using FluentAssertions;

namespace CleanArchMVCDomain.Teste
{
    public class CategoriaUnitTeste
    {
        [Fact(DisplayName ="Cria Categoria com validacao de estado")]
        public void CriaCategoria_ParametrosValidos_ResultadosComParametrosValidos()
        {
            Action action = () => new Categoria(1, "Categoria 1");
            action.Should()
                .NotThrow<ValidacoesExcecaoDominio>();
        } 
        [Fact(DisplayName ="Cria Categoria com id negativo")]
        public void CriaCategoria_ParametrosIdNegativo_ResultadosComParametrosInvalidos()
        {
            Action action = () => new Categoria(-1, "Categoria 1");
            action.Should()
                .Throw<ValidacoesExcecaoDominio>().WithMessage("Id inválido");
        }
    }
}