﻿using AppMvcBasica.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevIO.Data.Mappings
{
    public class FornecedorMapping : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.HasKey(keyExpression: p => p.Id);

            builder.Property(p => p.Nome)
                   .IsRequired()
                   .HasColumnType("varchar(200)");

            builder.Property(p => p.Documento)
                   .IsRequired()
                   .HasColumnType("varchar(14)");

            // 1: 1 => Fornecedor : Endereco
            builder.HasOne(navigationExpression: f => f.Endereco)
                .WithOne(navigationExpression: e => e.Fornecedor);

            // 1: N => Fornecedor : Produtos
            builder.HasMany(navigationExpression: f => f.Produtos)
                .WithOne(navigationExpression: p => p.Fornecedor)
                .HasForeignKey(p => p.FornecedorId);

            builder.ToTable("Fornecedores");
        }
    }
}
