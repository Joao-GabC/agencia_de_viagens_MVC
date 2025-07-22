using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AgenciaDeViagens.Migrations
{
    /// <inheritdoc />
    public partial class maisperiodos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pacotes",
                keyColumn: "Id",
                keyValue: 1,
                column: "NumDeVendas",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Pacotes",
                keyColumn: "Id",
                keyValue: 2,
                column: "NumDeVendas",
                value: 2);

            migrationBuilder.UpdateData(
                table: "PeriodosIndisponiveis",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataFim", "DataInicio", "PacoteId" },
                values: new object[] { new DateOnly(2026, 8, 15), new DateOnly(2026, 8, 1), 1 });

            migrationBuilder.InsertData(
                table: "PeriodosIndisponiveis",
                columns: new[] { "Id", "DataFim", "DataInicio", "PacoteId" },
                values: new object[,]
                {
                    { 3, new DateOnly(2026, 8, 30), new DateOnly(2024, 8, 10), 2 },
                    { 4, new DateOnly(2027, 7, 30), new DateOnly(2025, 7, 10), 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PeriodosIndisponiveis",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PeriodosIndisponiveis",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Pacotes",
                keyColumn: "Id",
                keyValue: 1,
                column: "NumDeVendas",
                value: 1248);

            migrationBuilder.UpdateData(
                table: "Pacotes",
                keyColumn: "Id",
                keyValue: 2,
                column: "NumDeVendas",
                value: 3129);

            migrationBuilder.UpdateData(
                table: "PeriodosIndisponiveis",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataFim", "DataInicio", "PacoteId" },
                values: new object[] { new DateOnly(2026, 8, 30), new DateOnly(2026, 8, 10), 2 });
        }
    }
}
