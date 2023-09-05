using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FeedbackClientes.RazorPages.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Feeedbacks",
                columns: table => new
                {
                    IdFeedback = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NomeCliente = table.Column<string>(type: "TEXT", nullable: false),
                    EmailCliente = table.Column<string>(type: "TEXT", nullable: true),
                    DataFeedback = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Comentário = table.Column<string>(type: "TEXT", nullable: false),
                    Avaliação = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feeedbacks", x => x.IdFeedback);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Feeedbacks");
        }
    }
}
