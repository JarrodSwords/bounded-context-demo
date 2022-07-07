using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoundedContextDemo.Infrastructure.Customers.Migrations
{
    public partial class SeedCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Name", "Surname" },
                values: new object[] { new Guid("7f4cfb45-0b44-4744-929e-1e6a7248d343"), "John", "Doe" });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Name", "Surname" },
                values: new object[] { new Guid("d5d297ec-9f3f-43fa-bdcb-4ea28da97bcd"), "Jane", "Doe" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("7f4cfb45-0b44-4744-929e-1e6a7248d343"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("d5d297ec-9f3f-43fa-bdcb-4ea28da97bcd"));
        }
    }
}
