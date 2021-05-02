using ControleFinanceiro.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.Infra.Mappings
{
    public class FuncaoMap : IEntityTypeConfiguration<Funcao>
    {
        public void Configure(EntityTypeBuilder<Funcao> builder)
        {
            builder.ToTable("Funcoes");

            builder.Property(f => f.Id).ValueGeneratedOnAdd();
            builder.Property(f => f.Descricao).IsRequired().HasMaxLength(60);

            builder.HasData(
                    new Funcao
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Administrador",
                        NormalizedName = "ADMINISTRADOR",
                        Descricao = "Administrador do sistema"
                    },
                    new Funcao
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Usuario",
                        NormalizedName = "USUARIO",
                        Descricao = "Usuário do sistema "
                    }
                );
        }
    }
}
