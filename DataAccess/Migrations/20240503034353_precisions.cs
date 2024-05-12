using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class precisions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "DB",
                table: "TreeMap",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "DCEO",
                table: "TreeMap",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "DCNS",
                table: "TreeMap",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "H",
                table: "TreeMap",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Frequency",
                table: "Colonies",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Na",
                table: "Colonies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "SurfaceH",
                table: "Colonies",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "SurfaceM",
                table: "Colonies",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DB",
                table: "TreeMap");

            migrationBuilder.DropColumn(
                name: "DCEO",
                table: "TreeMap");

            migrationBuilder.DropColumn(
                name: "DCNS",
                table: "TreeMap");

            migrationBuilder.DropColumn(
                name: "H",
                table: "TreeMap");

            migrationBuilder.DropColumn(
                name: "Frequency",
                table: "Colonies");

            migrationBuilder.DropColumn(
                name: "Na",
                table: "Colonies");

            migrationBuilder.DropColumn(
                name: "SurfaceH",
                table: "Colonies");

            migrationBuilder.DropColumn(
                name: "SurfaceM",
                table: "Colonies");
        }
    }
}
