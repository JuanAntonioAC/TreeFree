using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class relacionspecie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TreeMap_Species_SpecieIdSpecie",
                table: "TreeMap");

            migrationBuilder.DropIndex(
                name: "IX_TreeMap_SpecieIdSpecie",
                table: "TreeMap");

            migrationBuilder.DropColumn(
                name: "SpecieIdSpecie",
                table: "TreeMap");

            migrationBuilder.CreateIndex(
                name: "IX_TreeMap_IdSpecie",
                table: "TreeMap",
                column: "IdSpecie");

            migrationBuilder.AddForeignKey(
                name: "FK_TreeMap_Species_IdSpecie",
                table: "TreeMap",
                column: "IdSpecie",
                principalTable: "Species",
                principalColumn: "IdSpecie",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TreeMap_Species_IdSpecie",
                table: "TreeMap");

            migrationBuilder.DropIndex(
                name: "IX_TreeMap_IdSpecie",
                table: "TreeMap");

            migrationBuilder.AddColumn<int>(
                name: "SpecieIdSpecie",
                table: "TreeMap",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TreeMap_SpecieIdSpecie",
                table: "TreeMap",
                column: "SpecieIdSpecie");

            migrationBuilder.AddForeignKey(
                name: "FK_TreeMap_Species_SpecieIdSpecie",
                table: "TreeMap",
                column: "SpecieIdSpecie",
                principalTable: "Species",
                principalColumn: "IdSpecie",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
