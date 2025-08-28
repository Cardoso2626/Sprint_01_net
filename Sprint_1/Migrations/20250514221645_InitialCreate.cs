using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sprint_1.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        private const string TabelaChaveiro = "Chaveiro";
        private const string TabelaChaveiroUpper = "CHAVEIRO";
        
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chaveiro_Motos_MotoId",
                table: TabelaChaveiro);

            migrationBuilder.DropPrimaryKey(
                name: "PK_Chaveiro",
                table:TabelaChaveiro);

            migrationBuilder.RenameTable(
                name: TabelaChaveiro,
                newName: TabelaChaveiroUpper);

            migrationBuilder.RenameIndex(
                name: "IX_Chaveiro_MotoId",
                table: TabelaChaveiroUpper,
                newName: "IX_CHAVEIRO_MotoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CHAVEIRO",
                table: TabelaChaveiroUpper,
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CHAVEIRO_Motos_MotoId",
                table: TabelaChaveiroUpper,
                column: "MotoId",
                principalTable: "Motos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CHAVEIRO_Motos_MotoId",
                table: TabelaChaveiroUpper);

            migrationBuilder.DropPrimaryKey(
                name: "PK_CHAVEIRO",
                table: TabelaChaveiroUpper);

            migrationBuilder.RenameTable(
                name: TabelaChaveiroUpper,
                newName: TabelaChaveiro);

            migrationBuilder.RenameIndex(
                name: "IX_CHAVEIRO_MotoId",
                table: TabelaChaveiro,
                newName: "IX_Chaveiro_MotoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Chaveiro",
                table: TabelaChaveiro,
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Chaveiro_Motos_MotoId",
                table: TabelaChaveiro,
                column: "MotoId",
                principalTable: "Motos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
