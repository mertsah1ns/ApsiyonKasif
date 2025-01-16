using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApsiyonKasif.Repository.Migrations
{
    /// <inheritdoc />
    public partial class initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HomeId",
                table: "Adverts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Adverts_HomeId",
                table: "Adverts",
                column: "HomeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Adverts_Homes_HomeId",
                table: "Adverts",
                column: "HomeId",
                principalTable: "Homes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adverts_Homes_HomeId",
                table: "Adverts");

            migrationBuilder.DropIndex(
                name: "IX_Adverts_HomeId",
                table: "Adverts");

            migrationBuilder.DropColumn(
                name: "HomeId",
                table: "Adverts");
        }
    }
}
