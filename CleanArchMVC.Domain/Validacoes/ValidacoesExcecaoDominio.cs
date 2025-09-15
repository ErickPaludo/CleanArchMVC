using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMVC.Domain.Validacoes
{
    public class ValidacoesExcecaoDominio : Exception
    {
        public ValidacoesExcecaoDominio(string error) : base(error)
        {  
        }
        public static void Quando(bool possuiErro,string erro)
        {
            if (possuiErro)
                throw new ValidacoesExcecaoDominio(erro);
        }
    }
}
