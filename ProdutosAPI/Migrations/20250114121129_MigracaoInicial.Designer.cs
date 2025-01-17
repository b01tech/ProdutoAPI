﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProdutosAPI.Data;

#nullable disable

namespace ProdutosAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250114121129_MigracaoInicial")]
    partial class MigracaoInicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.11");

            modelBuilder.Entity("ProdutosAPI.Models.Produto", b =>
                {
                    b.Property<long>("ProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Ativo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("preco")
                        .HasColumnType("TEXT");

                    b.HasKey("ProdutoId");

                    b.ToTable("produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
