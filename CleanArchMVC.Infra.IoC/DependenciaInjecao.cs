using CleanArchMvc.Application.Interfaces;
using CleanArchMvc.Application.Services;
using CleanArchMVC.Application.Interfaces;
using CleanArchMVC.Application.Mapeamento;
using CleanArchMVC.Application.Servicos;
using CleanArchMVC.Domain.Interfaces;
using CleanArchMVC.Infra.Data.Context;
using CleanArchMVC.Infra.Data.Repositorios;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMVC.Infra.IoC
{
    public static class DependenciaInjecao
    {
        public static IServiceCollection AddInfraestrutura(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlite(configuration.GetConnectionString("Sqlite"), b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            services.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();
            services.AddScoped<ICategoriaRepositorio, CategoriaRepositorio>();
            services.AddScoped<ICategoriaServico, CategoriaServico>();
            services.AddScoped<IProdutoServico, ProdutoServico>();

            services.AddAutoMapper(typeof(MapeamentoDTOsDominio));
            return services;    
        }


    }
}
