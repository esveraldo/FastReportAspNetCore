using ApiFastReport.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFastReport.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empresa>().HasData(
                new Empresa
                {
                    Id = 1,
                    Nome = "Posto de gasolina Cidade",
                    Email = "posto@email.com",
                    Foto = "",
                    CreatedAt = DateTime.UtcNow
                }
            );

            modelBuilder.Entity<Categoria>().HasData(
                new Categoria
                {
                    Id = 1,
                    Descricao = "Combustivel",
                    CreatedAt = DateTime.UtcNow
                },
                new Categoria
                {
                    Id = 2,
                    Descricao = "Lubrificantes",
                    CreatedAt = DateTime.UtcNow
                },
                new Categoria
                {
                    Id = 3,
                    Descricao = "Diversos",
                    CreatedAt = DateTime.UtcNow
                }
            );

            modelBuilder.Entity<Produto>().HasData(
                new Produto
                {
                    Id = 1,
                    Descricao = "Gasolina aditivada",
                    Ean = "9789563530701",
                    Preco = 5.50m,
                    CreatedAt = DateTime.UtcNow,
                    CategoriaId = 1
                },
                new Produto
                {
                    Id = 2,
                    Descricao = "Gasolina comum",
                    Ean = "9789563530702",
                    Preco = 5.10m,
                    CreatedAt = DateTime.UtcNow,
                    CategoriaId = 1
                },
                new Produto
                {
                    Id = 3,
                    Descricao = "Alcool comum",
                    Ean = "9789563530703",
                    Preco = 4.00m,
                    CreatedAt = DateTime.UtcNow,
                    CategoriaId = 1
                },
                new Produto
                {
                    Id = 4,
                    Descricao = "Alcool aditivado comum",
                    Ean = "9789563530704",
                    Preco = 5.10m,
                    CreatedAt = DateTime.UtcNow,
                    CategoriaId = 1
                },
                new Produto
                {
                    Id = 5,
                    Descricao = "Disel",
                    Ean = "97895635307025",
                    Preco = 3.98m,
                    CreatedAt = DateTime.UtcNow,
                    CategoriaId = 1
                },
                new Produto
                {
                    Id = 6,
                    Descricao = "Oleo lubrificante 20w",
                    Ean = "9789563530710",
                    Preco = 20.00m,
                    CreatedAt = DateTime.UtcNow,
                    CategoriaId = 2
                },
                new Produto
                {
                    Id = 7,
                    Descricao = "Oleo lubrificante 40w",
                    Ean = "9789563530711",
                    Preco = 21.00m,
                    CreatedAt = DateTime.UtcNow,
                    CategoriaId = 2
                },
                new Produto
                {
                    Id = 8,
                    Descricao = "Agua sem gas",
                    Ean = "9789563530720",
                    Preco = 2.00m,
                    CreatedAt = DateTime.UtcNow,
                    CategoriaId = 3
                },
                new Produto
                {
                    Id = 9,
                    Descricao = "Agua com gas",
                    Ean = "97895635307121",
                    Preco = 2.10m,
                    CreatedAt = DateTime.UtcNow,
                    CategoriaId = 3
                }
            );

            modelBuilder.Entity<Usuario>().HasData(
                new Usuario
                {
                    Id = 1,
                    Nome = "Esveraldo Martins",
                    Email = "esveraldo@email.com",
                    CreatedAt = DateTime.UtcNow
                },
                new Usuario
                {
                    Id = 2,
                    Nome = "Adriana de Carvalho",
                    Email = "adriana@email.com",
                    CreatedAt = DateTime.UtcNow
                },
                new Usuario
                {
                    Id = 3,
                    Nome = "Anna Luiza",
                    Email = "anna@email.com",
                    CreatedAt = DateTime.UtcNow
                },
                new Usuario
                {
                    Id = 4,
                    Nome = "Maria Eduarda",
                    Email = "duda@email.com",
                    CreatedAt = DateTime.UtcNow
                },
                new Usuario
                {
                    Id = 5,
                    Nome = "Josefa Martins",
                    Email = "josefa@email.com",
                    CreatedAt = DateTime.UtcNow
                },
                new Usuario
                {
                    Id = 6,
                    Nome = "Xpto",
                    Email = "xpto@email.com",
                    CreatedAt = DateTime.UtcNow
                },
                new Usuario
                {
                    Id = 7,
                    Nome = "Batman",
                    Email = "batman@email.com",
                    CreatedAt = DateTime.UtcNow
                }
            );

            modelBuilder.Entity<Cliente>().HasData(
                new Cliente
                {
                    Id = 1,
                    Nome = "Sofia Marli Porto",
                    Email = "sofia@email.com",
                    CreatedAt = DateTime.UtcNow
                },
                new Cliente
                {
                    Id = 2,
                    Nome = "Raimunda Isis Olivia Vieira",
                    Email = "raimunda@email.com",
                    CreatedAt = DateTime.UtcNow
                },
                new Cliente
                {
                    Id = 3,
                    Nome = "Oliver Arthur da Mota",
                    Email = "oliver@email.com",
                    CreatedAt = DateTime.UtcNow
                }
            );
            modelBuilder.Entity<Venda>().HasData(
                new Venda
                {
                    Id = 1,
                    ClienteId = 2,
                    DataDaVenda = DateTime.UtcNow,
                    CreatedAt = DateTime.UtcNow,
                    TotalDaVenda = 100.00m
                },
                new Venda
                {
                    Id = 2,
                    ClienteId = 3,
                    DataDaVenda = DateTime.UtcNow,
                    CreatedAt = DateTime.UtcNow,
                    TotalDaVenda = 75.00m
                },
                new Venda
                {
                    Id = 3,
                    ClienteId = 1,
                    DataDaVenda = DateTime.UtcNow.AddDays(2),
                    CreatedAt = DateTime.UtcNow.AddDays(2),
                    TotalDaVenda = 100.00m
                }
            );
            modelBuilder.Entity<VendaItem>().HasData(
                new VendaItem
                {
                    Id = 1,
                    ProdutoId = 2,
                    VendaId = 1,
                    Quantidade = 19.607m,
                    ValorProduto = 5.10m,
                    TotalProduto = 100.00m
                },
                new VendaItem
                {
                    Id = 2,
                    ProdutoId = 2,
                    VendaId = 1,
                    Quantidade = 18.60718m,
                    ValorProduto = 5.50m,
                    TotalProduto = 100.00m
                },
                new VendaItem
                {
                    Id = 3,
                    ProdutoId = 1,
                    VendaId = 2,
                    Quantidade = 9.80m,
                    ValorProduto = 5.10m,
                    TotalProduto = 50.00m
                },
                new VendaItem
                {
                    Id = 4,
                    ProdutoId = 9,
                    VendaId = 2,
                    Quantidade = 11m,
                    ValorProduto = 2.10m,
                    TotalProduto = 25.00m
                },
                new VendaItem
                {
                    Id = 5,
                    ProdutoId = 5,
                    VendaId = 3,
                    Quantidade = 50.24m,
                    ValorProduto = 3.98m,
                    TotalProduto = 200.00m
                }
            );
        }
    }
}
