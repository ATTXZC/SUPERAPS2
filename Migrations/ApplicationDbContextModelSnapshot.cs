﻿// <auto-generated />
using Eco_life.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Eco_life.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Eco_life.Models.Cadastros", b =>
                {
                    b.Property<int>("ID_User")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CPF")
                        .HasColumnType("int");

                    b.Property<string>("Email_User")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome_User")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Senha_User")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("ID_User");

                    b.ToTable("Cadastros");
                });

            modelBuilder.Entity("Eco_life.Models.Funcionario", b =>
                {
                    b.Property<int>("Id_Funcionario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email_Funcionario")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Nome_Funcionario")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Senha_Funcionario")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Token")
                        .HasColumnType("longtext");

                    b.HasKey("Id_Funcionario");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("Eco_life.Models.Produtos", b =>
                {
                    b.Property<int>("ID_Produtos")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Estoque")
                        .HasColumnType("int");

                    b.Property<string>("Nome_Produto")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasMaxLength(900)
                        .HasColumnType("varchar(900)");

                    b.Property<decimal>("preco_produto")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("ID_Produtos");

                    b.ToTable("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
