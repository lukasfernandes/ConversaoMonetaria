﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConversaoMonetaria.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Moeda",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Codigo = table.Column<string>(type: "TEXT", nullable: false),
                    Cotacao = table.Column<decimal>(type: "TEXT", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moeda", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Moeda",
                columns: new[] { "Id", "Codigo", "Cotacao", "DataAtualizacao", "DataCadastro", "Nome", "Status" },
                values: new object[] { 1L, "BRL", 1m, null, new DateTime(2022, 7, 8, 17, 53, 50, 723, DateTimeKind.Local).AddTicks(3603), "Real Brasileiro", 0 });

            migrationBuilder.InsertData(
                table: "Moeda",
                columns: new[] { "Id", "Codigo", "Cotacao", "DataAtualizacao", "DataCadastro", "Nome", "Status" },
                values: new object[] { 2L, "USD", 5.3407m, null, new DateTime(2022, 7, 8, 17, 53, 50, 723, DateTimeKind.Local).AddTicks(3615), "Dólar Americano", 0 });

            migrationBuilder.InsertData(
                table: "Moeda",
                columns: new[] { "Id", "Codigo", "Cotacao", "DataAtualizacao", "DataCadastro", "Nome", "Status" },
                values: new object[] { 3L, "CAD", 4.1108m, null, new DateTime(2022, 7, 8, 17, 53, 50, 723, DateTimeKind.Local).AddTicks(3617), "Dólar Canadense", 0 });

            migrationBuilder.InsertData(
                table: "Moeda",
                columns: new[] { "Id", "Codigo", "Cotacao", "DataAtualizacao", "DataCadastro", "Nome", "Status" },
                values: new object[] { 4L, "GBP", 6.4083m, null, new DateTime(2022, 7, 8, 17, 53, 50, 723, DateTimeKind.Local).AddTicks(3618), "Libra Esterlina", 0 });

            migrationBuilder.InsertData(
                table: "Moeda",
                columns: new[] { "Id", "Codigo", "Cotacao", "DataAtualizacao", "DataCadastro", "Nome", "Status" },
                values: new object[] { 5L, "ARS", 0.0422m, null, new DateTime(2022, 7, 8, 17, 53, 50, 723, DateTimeKind.Local).AddTicks(3620), "Peso Argentino", 0 });

            migrationBuilder.InsertData(
                table: "Moeda",
                columns: new[] { "Id", "Codigo", "Cotacao", "DataAtualizacao", "DataCadastro", "Nome", "Status" },
                values: new object[] { 6L, "BTC", 115.668m, null, new DateTime(2022, 7, 8, 17, 53, 50, 723, DateTimeKind.Local).AddTicks(3622), "Bitcoin", 0 });

            migrationBuilder.InsertData(
                table: "Moeda",
                columns: new[] { "Id", "Codigo", "Cotacao", "DataAtualizacao", "DataCadastro", "Nome", "Status" },
                values: new object[] { 7L, "EUR", 5.4235m, null, new DateTime(2022, 7, 8, 17, 53, 50, 723, DateTimeKind.Local).AddTicks(3624), "Euro", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Moeda");
        }
    }
}
