using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class relacioncolony : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TreeMap_Colonies_ColonyIdColony",
                table: "TreeMap");

            migrationBuilder.DropIndex(
                name: "IX_TreeMap_ColonyIdColony",
                table: "TreeMap");

            migrationBuilder.DropColumn(
                name: "ColonyIdColony",
                table: "TreeMap");

            migrationBuilder.CreateIndex(
                name: "IX_TreeMap_IdColony",
                table: "TreeMap",
                column: "IdColony");

            migrationBuilder.AddForeignKey(
                name: "FK_TreeMap_Colonies_IdColony",
                table: "TreeMap",
                column: "IdColony",
                principalTable: "Colonies",
                principalColumn: "IdColony",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TreeMap_Colonies_IdColony",
                table: "TreeMap");

            migrationBuilder.DropIndex(
                name: "IX_TreeMap_IdColony",
                table: "TreeMap");

            migrationBuilder.AddColumn<int>(
                name: "ColonyIdColony",
                table: "TreeMap",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TreeMap_ColonyIdColony",
                table: "TreeMap",
                column: "ColonyIdColony");

            migrationBuilder.AddForeignKey(
                name: "FK_TreeMap_Colonies_ColonyIdColony",
                table: "TreeMap",
                column: "ColonyIdColony",
                principalTable: "Colonies",
                principalColumn: "IdColony",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
