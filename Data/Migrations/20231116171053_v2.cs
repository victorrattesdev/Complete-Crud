using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Crud.Data.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Exclusives");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Exclusives",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Exclusives");

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Exclusives",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
