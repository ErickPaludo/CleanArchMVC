using CleanArchMVC.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMVC.Infra.Data.EntitiesConfiguration
{
    public class ConfiguracaoProduto : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Descricao).HasMaxLength(200);
            builder.Property(p => p.Preco).HasPrecision(10, 2);

            builder.HasOne(e => e.Categoria).WithMany(c => c.Produtos)
                   .HasForeignKey(e => e.CategoriaId);
        }
    }
}
