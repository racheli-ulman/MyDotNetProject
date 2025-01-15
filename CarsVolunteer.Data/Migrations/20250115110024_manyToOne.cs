using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarsVolunteer.Data.Migrations
{
    public partial class manyToOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "travels",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VolunteerId",
                table: "travels",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_travels_CustomerId",
                table: "travels",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_travels_VolunteerId",
                table: "travels",
                column: "VolunteerId");

            migrationBuilder.AddForeignKey(
                name: "FK_travels_customers_CustomerId",
                table: "travels",
                column: "CustomerId",
                principalTable: "customers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_travels_volunteers_VolunteerId",
                table: "travels",
                column: "VolunteerId",
                principalTable: "volunteers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_travels_customers_CustomerId",
                table: "travels");

            migrationBuilder.DropForeignKey(
                name: "FK_travels_volunteers_VolunteerId",
                table: "travels");

            migrationBuilder.DropIndex(
                name: "IX_travels_CustomerId",
                table: "travels");

            migrationBuilder.DropIndex(
                name: "IX_travels_VolunteerId",
                table: "travels");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "travels");

            migrationBuilder.DropColumn(
                name: "VolunteerId",
                table: "travels");
        }
    }
}
