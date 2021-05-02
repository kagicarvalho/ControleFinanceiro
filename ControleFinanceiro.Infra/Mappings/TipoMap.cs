using ControleFinanceiro.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.Infra.Mappings
{
    public class TipoMap : IEntityTypeConfiguration<Tipo>
    {
        public void Configure(EntityTypeBuilder<Tipo> builder)
        {
            builder.ToTable("Tipos");

            builder.HasKey(t => t.TipoId);
            builder.Property(t => t.Nome).IsRequired().HasMaxLength(40);
            builder.HasMany(t => t.Categorias).WithOne(t => t.Tipo);

            builder.HasData(
                new Tipo
                {
                    TipoId = 1,
                    Nome = "Despesa"
                },
                new Tipo
                {
                    TipoId = 2,
                    Nome = "Ganho"
                }
                );
        }
    }
}
