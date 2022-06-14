using AppMvcBasica.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Data.Mappings
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(keyExpression: p => p.Id);

            builder.Property(p => p.Nome)
                   .IsRequired()
                   .HasColumnType("varchar(200)");

            builder.Property(p => p.Descricao)
                   .IsRequired()
                   .HasColumnType("varchar(1000)");

            builder.Property(p => p.Imagem)
                   .IsRequired()
                   .HasColumnType("varchar(100)");

            builder.ToTable("Produtos");
        }
    }

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

    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(keyExpression: p => p.Id);

            builder.Property(p => p.Logradouro)
                   .IsRequired()
                   .HasColumnType("varchar(200)");

            builder.Property(p => p.Numero)
                   .IsRequired()
                   .HasColumnType("varchar(50)");

            builder.Property(p => p.Cep)
                   .IsRequired()
                   .HasColumnType("varchar(8)");

            builder.Property(p => p.Complemento)
                   .IsRequired()
                   .HasColumnType("varchar(250)");

            builder.Property(p => p.Bairro)
                   .IsRequired()
                   .HasColumnType("varchar(100)");

            builder.Property(p => p.Cidade)
                   .IsRequired()
                   .HasColumnType("varchar(100)");

            builder.Property(p => p.Estado)
                   .IsRequired()
                   .HasColumnType("varchar(50)");

            builder.ToTable("Enderecos");
        }
    }
}
