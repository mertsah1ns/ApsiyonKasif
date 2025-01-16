using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApsiyonKasif.Repository.Migrations
{
    /// <inheritdoc />
    public partial class HomeEntityAddFurnishedColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HasFurnished",
                table: "Homes",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasFurnished",
                table: "Homes");
        }
    }
}
