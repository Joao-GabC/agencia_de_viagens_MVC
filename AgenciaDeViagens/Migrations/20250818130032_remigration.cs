using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AgenciaDeViagens.Migrations
{
    /// <inheritdoc />
    public partial class remigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PeriodosIndisponiveis",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PeriodosIndisponiveis",
                keyColumn: "Id",
                keyValue: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PeriodosIndisponiveis",
                columns: new[] { "Id", "DataFim", "DataInicio", "PacoteId" },
                values: new object[,]
                {
                    { 1, new DateOnly(2026, 7, 30), new DateOnly(2026, 7, 10), 1 },
                    { 2, new DateOnly(2026, 8, 30), new DateOnly(2026, 8, 10), 2 }
                });
        }
    }
}
