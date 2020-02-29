using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SysFin.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PrestadoresDeServico",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Nome = table.Column<string>(maxLength: 30, nullable: false),
                    Descricao = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrestadoresDeServico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Faturas",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    DataChegada = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 2, 28, 20, 28, 55, 412, DateTimeKind.Local).AddTicks(4573)),
                    DataVencimento = table.Column<DateTime>(nullable: false),
                    MesReferencia = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 2, 28, 20, 28, 55, 433, DateTimeKind.Local).AddTicks(358)),
                    Valor = table.Column<decimal>(nullable: false),
                    Observacao = table.Column<string>(maxLength: 100, nullable: true),
                    PrestadorId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faturas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Faturas_PrestadoresDeServico_PrestadorId",
                        column: x => x.PrestadorId,
                        principalTable: "PrestadoresDeServico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "PrestadoresDeServico",
                columns: new[] { "Id", "Descricao", "Nome" },
                values: new object[] { "67AA1C8DA3B74D048599", "Prestador de servico", "Energisa" });

            migrationBuilder.CreateIndex(
                name: "IX_Faturas_PrestadorId",
                table: "Faturas",
                column: "PrestadorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Faturas");

            migrationBuilder.DropTable(
                name: "PrestadoresDeServico");
        }
    }
}
