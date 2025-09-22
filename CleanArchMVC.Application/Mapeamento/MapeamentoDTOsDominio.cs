using AutoMapper;
using CleanArchMVC.Application.DTOs;
using CleanArchMVC.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMVC.Application.Mapeamento
{
    public class MapeamentoDTOsDominio : Profile
    {
        public MapeamentoDTOsDominio()
        {
            CreateMap<CategoriaDTO,Categoria>().ReverseMap();
            CreateMap<ProdutosDTO, Produto>().ReverseMap();
        }
    }
}
