using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreAppPhase2.Migrations
{
    public partial class InitialUpdateBookingServices_01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BookingName",
                table: "BookingServices",
                newName: "BookerName");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                table: "BookingServices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BookingDate",
                table: "BookingServices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "BookingPrices",
                table: "BookingServices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdEM",
                table: "BookingServices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ItemID",
                table: "BookingServices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SaleInvoicesSaleInvoiceID",
                table: "BookingServices",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookingServices_IdEM",
                table: "BookingServices",
                column: "IdEM");

            migrationBuilder.CreateIndex(
                name: "IX_BookingServices_SaleInvoicesSaleInvoiceID",
                table: "BookingServices",
                column: "SaleInvoicesSaleInvoiceID");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingServices_EmployeesDatas_IdEM",
                table: "BookingServices",
                column: "IdEM",
                principalTable: "EmployeesDatas",
                principalColumn: "IdEm",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookingServices_SaleInvoices_SaleInvoicesSaleInvoiceID",
                table: "BookingServices",
                column: "SaleInvoicesSaleInvoiceID",
                principalTable: "SaleInvoices",
                principalColumn: "SaleInvoiceID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingServices_EmployeesDatas_IdEM",
                table: "BookingServices");

            migrationBuilder.DropForeignKey(
                name: "FK_BookingServices_SaleInvoices_SaleInvoicesSaleInvoiceID",
                table: "BookingServices");

            migrationBuilder.DropIndex(
                name: "IX_BookingServices_IdEM",
                table: "BookingServices");

            migrationBuilder.DropIndex(
                name: "IX_BookingServices_SaleInvoicesSaleInvoiceID",
                table: "BookingServices");

            migrationBuilder.DropColumn(
                name: "BookingDate",
                table: "BookingServices");

            migrationBuilder.DropColumn(
                name: "BookingPrices",
                table: "BookingServices");

            migrationBuilder.DropColumn(
                name: "IdEM",
                table: "BookingServices");

            migrationBuilder.DropColumn(
                name: "ItemID",
                table: "BookingServices");

            migrationBuilder.DropColumn(
                name: "SaleInvoicesSaleInvoiceID",
                table: "BookingServices");

            migrationBuilder.RenameColumn(
                name: "BookerName",
                table: "BookingServices",
                newName: "BookingName");

            migrationBuilder.AlterColumn<string>(
                name: "DueDate",
                table: "BookingServices",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
