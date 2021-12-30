﻿// <auto-generated />
using System;
using ApiFastReport.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiFastReport.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ApiFastReport.Entity.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Categorias");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2021, 12, 30, 15, 6, 3, 603, DateTimeKind.Utc).AddTicks(7940),
                            Descricao = "Combustivel"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2021, 12, 30, 15, 6, 3, 603, DateTimeKind.Utc).AddTicks(7969),
                            Descricao = "Lubrificantes"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2021, 12, 30, 15, 6, 3, 603, DateTimeKind.Utc).AddTicks(7970),
                            Descricao = "Diversos"
                        });
                });

            modelBuilder.Entity("ApiFastReport.Entity.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2021, 12, 30, 15, 6, 3, 604, DateTimeKind.Utc).AddTicks(602),
                            Email = "sofia@email.com",
                            Nome = "Sofia Marli Porto"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2021, 12, 30, 15, 6, 3, 604, DateTimeKind.Utc).AddTicks(629),
                            Email = "raimunda@email.com",
                            Nome = "Raimunda Isis Olivia Vieira"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2021, 12, 30, 15, 6, 3, 604, DateTimeKind.Utc).AddTicks(630),
                            Email = "oliver@email.com",
                            Nome = "Oliver Arthur da Mota"
                        });
                });

            modelBuilder.Entity("ApiFastReport.Entity.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Foto")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Empresas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2021, 12, 30, 15, 6, 3, 602, DateTimeKind.Utc).AddTicks(9488),
                            Email = "posto@email.com",
                            Foto = "",
                            Nome = "Posto de gasolina Cidade"
                        });
                });

            modelBuilder.Entity("ApiFastReport.Entity.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Ean")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Produtos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoriaId = 1,
                            CreatedAt = new DateTime(2021, 12, 30, 15, 6, 3, 603, DateTimeKind.Utc).AddTicks(9000),
                            Descricao = "Gasolina aditivada",
                            Ean = "9789563530701",
                            Preco = 5.50m
                        },
                        new
                        {
                            Id = 2,
                            CategoriaId = 1,
                            CreatedAt = new DateTime(2021, 12, 30, 15, 6, 3, 603, DateTimeKind.Utc).AddTicks(9221),
                            Descricao = "Gasolina comum",
                            Ean = "9789563530702",
                            Preco = 5.10m
                        },
                        new
                        {
                            Id = 3,
                            CategoriaId = 1,
                            CreatedAt = new DateTime(2021, 12, 30, 15, 6, 3, 603, DateTimeKind.Utc).AddTicks(9234),
                            Descricao = "Alcool comum",
                            Ean = "9789563530703",
                            Preco = 4.00m
                        },
                        new
                        {
                            Id = 4,
                            CategoriaId = 1,
                            CreatedAt = new DateTime(2021, 12, 30, 15, 6, 3, 603, DateTimeKind.Utc).AddTicks(9236),
                            Descricao = "Alcool aditivado comum",
                            Ean = "9789563530704",
                            Preco = 5.10m
                        },
                        new
                        {
                            Id = 5,
                            CategoriaId = 1,
                            CreatedAt = new DateTime(2021, 12, 30, 15, 6, 3, 603, DateTimeKind.Utc).AddTicks(9237),
                            Descricao = "Disel",
                            Ean = "97895635307025",
                            Preco = 3.98m
                        },
                        new
                        {
                            Id = 6,
                            CategoriaId = 2,
                            CreatedAt = new DateTime(2021, 12, 30, 15, 6, 3, 603, DateTimeKind.Utc).AddTicks(9238),
                            Descricao = "Oleo lubrificante 20w",
                            Ean = "9789563530710",
                            Preco = 20.00m
                        },
                        new
                        {
                            Id = 7,
                            CategoriaId = 2,
                            CreatedAt = new DateTime(2021, 12, 30, 15, 6, 3, 603, DateTimeKind.Utc).AddTicks(9239),
                            Descricao = "Oleo lubrificante 40w",
                            Ean = "9789563530711",
                            Preco = 21.00m
                        },
                        new
                        {
                            Id = 8,
                            CategoriaId = 3,
                            CreatedAt = new DateTime(2021, 12, 30, 15, 6, 3, 603, DateTimeKind.Utc).AddTicks(9240),
                            Descricao = "Agua sem gas",
                            Ean = "9789563530720",
                            Preco = 2.00m
                        },
                        new
                        {
                            Id = 9,
                            CategoriaId = 3,
                            CreatedAt = new DateTime(2021, 12, 30, 15, 6, 3, 603, DateTimeKind.Utc).AddTicks(9241),
                            Descricao = "Agua com gas",
                            Ean = "97895635307121",
                            Preco = 2.10m
                        });
                });

            modelBuilder.Entity("ApiFastReport.Entity.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2021, 12, 30, 15, 6, 3, 603, DateTimeKind.Utc).AddTicks(9933),
                            Email = "esveraldo@email.com",
                            Nome = "Esveraldo Martins"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2021, 12, 30, 15, 6, 3, 603, DateTimeKind.Utc).AddTicks(9956),
                            Email = "adriana@email.com",
                            Nome = "Adriana de Carvalho"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2021, 12, 30, 15, 6, 3, 603, DateTimeKind.Utc).AddTicks(9958),
                            Email = "anna@email.com",
                            Nome = "Anna Luiza"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2021, 12, 30, 15, 6, 3, 603, DateTimeKind.Utc).AddTicks(9958),
                            Email = "duda@email.com",
                            Nome = "Maria Eduarda"
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2021, 12, 30, 15, 6, 3, 603, DateTimeKind.Utc).AddTicks(9959),
                            Email = "josefa@email.com",
                            Nome = "Josefa Martins"
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2021, 12, 30, 15, 6, 3, 603, DateTimeKind.Utc).AddTicks(9960),
                            Email = "xpto@email.com",
                            Nome = "Xpto"
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2021, 12, 30, 15, 6, 3, 603, DateTimeKind.Utc).AddTicks(9961),
                            Email = "batman@email.com",
                            Nome = "Batman"
                        });
                });

            modelBuilder.Entity("ApiFastReport.Entity.Venda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataDaVenda")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("TotalDaVenda")
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Vendas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClienteId = 2,
                            CreatedAt = new DateTime(2021, 12, 30, 15, 6, 3, 604, DateTimeKind.Utc).AddTicks(1353),
                            DataDaVenda = new DateTime(2021, 12, 30, 15, 6, 3, 604, DateTimeKind.Utc).AddTicks(1105),
                            TotalDaVenda = 100.00m
                        },
                        new
                        {
                            Id = 2,
                            ClienteId = 3,
                            CreatedAt = new DateTime(2021, 12, 30, 15, 6, 3, 604, DateTimeKind.Utc).AddTicks(1620),
                            DataDaVenda = new DateTime(2021, 12, 30, 15, 6, 3, 604, DateTimeKind.Utc).AddTicks(1612),
                            TotalDaVenda = 75.00m
                        },
                        new
                        {
                            Id = 3,
                            ClienteId = 1,
                            CreatedAt = new DateTime(2022, 1, 1, 15, 6, 3, 604, DateTimeKind.Utc).AddTicks(1721),
                            DataDaVenda = new DateTime(2022, 1, 1, 15, 6, 3, 604, DateTimeKind.Utc).AddTicks(1627),
                            TotalDaVenda = 100.00m
                        });
                });

            modelBuilder.Entity("ApiFastReport.Entity.VendaItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<decimal>("Quantidade")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("TotalProduto")
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("ValorProduto")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("VendaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.HasIndex("VendaId");

                    b.ToTable("VendaItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ProdutoId = 2,
                            Quantidade = 19.607m,
                            TotalProduto = 100.00m,
                            ValorProduto = 5.10m,
                            VendaId = 1
                        },
                        new
                        {
                            Id = 2,
                            ProdutoId = 2,
                            Quantidade = 18.60718m,
                            TotalProduto = 100.00m,
                            ValorProduto = 5.50m,
                            VendaId = 1
                        },
                        new
                        {
                            Id = 3,
                            ProdutoId = 1,
                            Quantidade = 9.80m,
                            TotalProduto = 50.00m,
                            ValorProduto = 5.10m,
                            VendaId = 2
                        },
                        new
                        {
                            Id = 4,
                            ProdutoId = 9,
                            Quantidade = 11m,
                            TotalProduto = 25.00m,
                            ValorProduto = 2.10m,
                            VendaId = 2
                        },
                        new
                        {
                            Id = 5,
                            ProdutoId = 5,
                            Quantidade = 50.24m,
                            TotalProduto = 200.00m,
                            ValorProduto = 3.98m,
                            VendaId = 3
                        });
                });

            modelBuilder.Entity("ApiFastReport.Entity.Produto", b =>
                {
                    b.HasOne("ApiFastReport.Entity.Categoria", "Categoria")
                        .WithMany("Produtos")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApiFastReport.Entity.Venda", b =>
                {
                    b.HasOne("ApiFastReport.Entity.Cliente", "Cliente")
                        .WithMany("Vendas")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApiFastReport.Entity.VendaItem", b =>
                {
                    b.HasOne("ApiFastReport.Entity.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiFastReport.Entity.Venda", "Venda")
                        .WithMany("VendaItems")
                        .HasForeignKey("VendaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}