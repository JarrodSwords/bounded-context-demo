using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoundedContextDemo.Infrastructure.Customers.Migrations
{
    public partial class AddShipment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("7f4cfb45-0b44-4744-929e-1e6a7248d343"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("d5d297ec-9f3f-43fa-bdcb-4ea28da97bcd"));

            migrationBuilder.CreateTable(
                name: "Shipment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LineItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShipmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Units = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LineItem_Shipment_ShipmentId",
                        column: x => x.ShipmentId,
                        principalTable: "Shipment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Name", "Surname" },
                values: new object[] { new Guid("5e9762c8-03ea-4a10-b4cc-b704385de152"), "Jane", "Doe" });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Name", "Surname" },
                values: new object[] { new Guid("ff784bab-f9bd-43d1-9ab0-4ee8ae915a8f"), "John", "Doe" });

            migrationBuilder.CreateIndex(
                name: "IX_LineItem_ShipmentId",
                table: "LineItem",
                column: "ShipmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LineItem");

            migrationBuilder.DropTable(
                name: "Shipment");

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("5e9762c8-03ea-4a10-b4cc-b704385de152"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("ff784bab-f9bd-43d1-9ab0-4ee8ae915a8f"));

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Name", "Surname" },
                values: new object[] { new Guid("7f4cfb45-0b44-4744-929e-1e6a7248d343"), "John", "Doe" });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Name", "Surname" },
                values: new object[] { new Guid("d5d297ec-9f3f-43fa-bdcb-4ea28da97bcd"), "Jane", "Doe" });
        }
    }
}
