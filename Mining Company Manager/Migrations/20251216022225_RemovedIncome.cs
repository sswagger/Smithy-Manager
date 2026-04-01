using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmithyManager.Migrations
{
    /// <inheritdoc />
    public partial class RemovedIncome : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Income",
                table: "Shops");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Income",
                table: "Shops",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
