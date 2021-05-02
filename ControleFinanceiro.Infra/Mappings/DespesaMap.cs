using ControleFinanceiro.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.Infra.Mappings
{
    public class DespesaMap : IEntityTypeConfiguration<Despesa>
    {
        public void Configure(EntityTypeBuilder<Despesa> builder)
        {
            builder.ToTable("Despesas");

            builder.HasKey(d => d.DespesaId);

            builder.Property(d => d.Descricao).IsRequired().HasMaxLength(50);
            builder.Property(d => d.Dia).IsRequired();
            builder.Property(d => d.Ano).IsRequired();
            builder.Property(d => d.Valor).IsRequired().HasColumnType("decimal(18,2)");

            builder.HasOne(d => d.Cartao).WithMany(d => d.Despesas).HasForeignKey(d => d.DespesaId).IsRequired();
            builder.HasOne(d => d.Categoria).WithMany(d => d.Despesas).HasForeignKey(d => d.CategoriaId).IsRequired();
            builder.HasOne(d => d.Mes).WithMany(d => d.Despesas).HasForeignKey(d => d.MesId).IsRequired();
            builder.HasOne(d => d.Usuario).WithMany(d => d.Despesas).HasForeignKey(d => d.UsuarioId).IsRequired();
        }
    }
}
