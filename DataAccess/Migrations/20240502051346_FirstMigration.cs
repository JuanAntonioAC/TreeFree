using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Colonies",
                columns: table => new
                {
                    IdColony = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colonies", x => x.IdColony);
                });

            migrationBuilder.CreateTable(
                name: "Species",
                columns: table => new
                {
                    IdSpecie = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommonName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    scientificName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Species", x => x.IdSpecie);
                });

            migrationBuilder.CreateTable(
                name: "TreeMap",
                columns: table => new
                {
                    IdTree = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdColony = table.Column<int>(type: "int", nullable: false),
                    ColonyIdColony = table.Column<int>(type: "int", nullable: false),
                    IdSpecie = table.Column<int>(type: "int", nullable: false),
                    SpecieIdSpecie = table.Column<int>(type: "int", nullable: false),
                    Xcoordinate = table.Column<int>(type: "int", nullable: false),
                    Ycoordinate = table.Column<int>(type: "int", nullable: false),
                    Stage = table.Column<int>(type: "int", nullable: false),
                    EFT = table.Column<int>(type: "int", nullable: false),
                    EST = table.Column<int>(type: "int", nullable: false),
                    EFC = table.Column<int>(type: "int", nullable: false),
                    ESC = table.Column<int>(type: "int", nullable: false),
                    Sa = table.Column<int>(type: "int", nullable: false),
                    Condition = table.Column<int>(type: "int", nullable: false),
                    Risk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TreeMap", x => x.IdTree);
                    table.ForeignKey(
                        name: "FK_TreeMap_Colonies_ColonyIdColony",
                        column: x => x.ColonyIdColony,
                        principalTable: "Colonies",
                        principalColumn: "IdColony",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TreeMap_Species_SpecieIdSpecie",
                        column: x => x.SpecieIdSpecie,
                        principalTable: "Species",
                        principalColumn: "IdSpecie",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TreeMap_ColonyIdColony",
                table: "TreeMap",
                column: "ColonyIdColony");

            migrationBuilder.CreateIndex(
                name: "IX_TreeMap_SpecieIdSpecie",
                table: "TreeMap",
                column: "SpecieIdSpecie");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TreeMap");

            migrationBuilder.DropTable(
                name: "Colonies");

            migrationBuilder.DropTable(
                name: "Species");
        }
    }
}
