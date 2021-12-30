using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiFastReport.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Foto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    Preco = table.Column<decimal>(nullable: false),
                    Ean = table.Column<string>(nullable: true),
                    CategoriaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produtos_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vendas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DataDaVenda = table.Column<DateTime>(nullable: false),
                    TotalDaVenda = table.Column<decimal>(nullable: false),
                    ClienteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vendas_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VendaItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    Quantidade = table.Column<decimal>(nullable: false),
                    ValorProduto = table.Column<decimal>(nullable: false),
                    TotalProduto = table.Column<decimal>(nullable: false),
                    VendaId = table.Column<int>(nullable: false),
                    ProdutoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendaItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VendaItems_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VendaItems_Vendas_VendaId",
                        column: x => x.VendaId,
                        principalTable: "Vendas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Id", "CreatedAt", "Descricao", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 12, 30, 15, 6, 3, 603, DateTimeKind.Utc).AddTicks(7940), "Combustivel", null },
                    { 2, new DateTime(2021, 12, 30, 15, 6, 3, 603, DateTimeKind.Utc).AddTicks(7969), "Lubrificantes", null },
                    { 3, new DateTime(2021, 12, 30, 15, 6, 3, 603, DateTimeKind.Utc).AddTicks(7970), "Diversos", null }
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "CreatedAt", "Email", "Nome", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 12, 30, 15, 6, 3, 604, DateTimeKind.Utc).AddTicks(602), "sofia@email.com", "Sofia Marli Porto", null },
                    { 2, new DateTime(2021, 12, 30, 15, 6, 3, 604, DateTimeKind.Utc).AddTicks(629), "raimunda@email.com", "Raimunda Isis Olivia Vieira", null },
                    { 3, new DateTime(2021, 12, 30, 15, 6, 3, 604, DateTimeKind.Utc).AddTicks(630), "oliver@email.com", "Oliver Arthur da Mota", null }
                });

            migrationBuilder.InsertData(
                table: "Empresas",
                columns: new[] { "Id", "CreatedAt", "Email", "Foto", "Nome", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2021, 12, 30, 15, 6, 3, 602, DateTimeKind.Utc).AddTicks(9488), "posto@email.com", "", "Posto de gasolina Cidade", null });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "CreatedAt", "Email", "Nome", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 12, 30, 15, 6, 3, 603, DateTimeKind.Utc).AddTicks(9933), "esveraldo@email.com", "Esveraldo Martins", null },
                    { 2, new DateTime(2021, 12, 30, 15, 6, 3, 603, DateTimeKind.Utc).AddTicks(9956), "adriana@email.com", "Adriana de Carvalho", null },
                    { 3, new DateTime(2021, 12, 30, 15, 6, 3, 603, DateTimeKind.Utc).AddTicks(9958), "anna@email.com", "Anna Luiza", null },
                    { 4, new DateTime(2021, 12, 30, 15, 6, 3, 603, DateTimeKind.Utc).AddTicks(9958), "duda@email.com", "Maria Eduarda", null },
                    { 5, new DateTime(2021, 12, 30, 15, 6, 3, 603, DateTimeKind.Utc).AddTicks(9959), "josefa@email.com", "Josefa Martins", null },
                    { 6, new DateTime(2021, 12, 30, 15, 6, 3, 603, DateTimeKind.Utc).AddTicks(9960), "xpto@email.com", "Xpto", null },
                    { 7, new DateTime(2021, 12, 30, 15, 6, 3, 603, DateTimeKind.Utc).AddTicks(9961), "batman@email.com", "Batman", null }
                });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "CategoriaId", "CreatedAt", "Descricao", "Ean", "Preco", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 12, 30, 15, 6, 3, 603, DateTimeKind.Utc).AddTicks(9000), "Gasolina aditivada", "9789563530701", 5.50m, null },
                    { 2, 1, new DateTime(2021, 12, 30, 15, 6, 3, 603, DateTimeKind.Utc).AddTicks(9221), "Gasolina comum", "9789563530702", 5.10m, null },
                    { 3, 1, new DateTime(2021, 12, 30, 15, 6, 3, 603, DateTimeKind.Utc).AddTicks(9234), "Alcool comum", "9789563530703", 4.00m, null },
                    { 4, 1, new DateTime(2021, 12, 30, 15, 6, 3, 603, DateTimeKind.Utc).AddTicks(9236), "Alcool aditivado comum", "9789563530704", 5.10m, null },
                    { 5, 1, new DateTime(2021, 12, 30, 15, 6, 3, 603, DateTimeKind.Utc).AddTicks(9237), "Disel", "97895635307025", 3.98m, null },
                    { 6, 2, new DateTime(2021, 12, 30, 15, 6, 3, 603, DateTimeKind.Utc).AddTicks(9238), "Oleo lubrificante 20w", "9789563530710", 20.00m, null },
                    { 7, 2, new DateTime(2021, 12, 30, 15, 6, 3, 603, DateTimeKind.Utc).AddTicks(9239), "Oleo lubrificante 40w", "9789563530711", 21.00m, null },
                    { 8, 3, new DateTime(2021, 12, 30, 15, 6, 3, 603, DateTimeKind.Utc).AddTicks(9240), "Agua sem gas", "9789563530720", 2.00m, null },
                    { 9, 3, new DateTime(2021, 12, 30, 15, 6, 3, 603, DateTimeKind.Utc).AddTicks(9241), "Agua com gas", "97895635307121", 2.10m, null }
                });

            migrationBuilder.InsertData(
                table: "Vendas",
                columns: new[] { "Id", "ClienteId", "CreatedAt", "DataDaVenda", "TotalDaVenda", "UpdatedAt" },
                values: new object[,]
                {
                    { 3, 1, new DateTime(2022, 1, 1, 15, 6, 3, 604, DateTimeKind.Utc).AddTicks(1721), new DateTime(2022, 1, 1, 15, 6, 3, 604, DateTimeKind.Utc).AddTicks(1627), 100.00m, null },
                    { 1, 2, new DateTime(2021, 12, 30, 15, 6, 3, 604, DateTimeKind.Utc).AddTicks(1353), new DateTime(2021, 12, 30, 15, 6, 3, 604, DateTimeKind.Utc).AddTicks(1105), 100.00m, null },
                    { 2, 3, new DateTime(2021, 12, 30, 15, 6, 3, 604, DateTimeKind.Utc).AddTicks(1620), new DateTime(2021, 12, 30, 15, 6, 3, 604, DateTimeKind.Utc).AddTicks(1612), 75.00m, null }
                });

            migrationBuilder.InsertData(
                table: "VendaItems",
                columns: new[] { "Id", "CreatedAt", "ProdutoId", "Quantidade", "TotalProduto", "UpdatedAt", "ValorProduto", "VendaId" },
                values: new object[,]
                {
                    { 5, null, 5, 50.24m, 200.00m, null, 3.98m, 3 },
                    { 1, null, 2, 19.607m, 100.00m, null, 5.10m, 1 },
                    { 2, null, 2, 18.60718m, 100.00m, null, 5.50m, 1 },
                    { 3, null, 1, 9.80m, 50.00m, null, 5.10m, 2 },
                    { 4, null, 9, 11m, 25.00m, null, 2.10m, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_CategoriaId",
                table: "Produtos",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_VendaItems_ProdutoId",
                table: "VendaItems",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_VendaItems_VendaId",
                table: "VendaItems",
                column: "VendaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_ClienteId",
                table: "Vendas",
                column: "ClienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empresas");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "VendaItems");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Vendas");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
