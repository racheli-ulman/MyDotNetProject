using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarsVolunteer.Data.Migrations
{
    public partial class oneToOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_travels_customers_CustomerId",
                table: "travels");

            migrationBuilder.DropForeignKey(
                name: "FK_travels_volunteers_VolunteerId",
                table: "travels");

            migrationBuilder.AlterColumn<int>(
                name: "VolunteerId",
                table: "travels",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "travels",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_travels_customers_CustomerId",
                table: "travels",
                column: "CustomerId",
                principalTable: "customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_travels_volunteers_VolunteerId",
                table: "travels",
                column: "VolunteerId",
                principalTable: "volunteers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_travels_customers_CustomerId",
                table: "travels");

            migrationBuilder.DropForeignKey(
                name: "FK_travels_volunteers_VolunteerId",
                table: "travels");

            migrationBuilder.AlterColumn<int>(
                name: "VolunteerId",
                table: "travels",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "travels",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
    }
}
