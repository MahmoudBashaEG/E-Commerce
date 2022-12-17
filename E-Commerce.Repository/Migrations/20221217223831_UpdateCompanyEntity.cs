using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.Repository.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCompanyEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<short>(
                name: "EndingMinute",
                table: "Companies",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "StartingMinute",
                table: "Companies",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndingMinute",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "StartingMinute",
                table: "Companies");
        }
    }
}
