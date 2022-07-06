using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoundedContextDemo.Infrastructure.Migrations
{
    public partial class AddUnitsOnHand : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "UnitsOnHand",
                table: "Product",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnitsOnHand",
                table: "Product");
        }
    }
}
