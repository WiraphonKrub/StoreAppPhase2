using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreAppPhase2.Migrations
{
    public partial class InitialReStructureDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingServices_EmployeesDatas_IdEM",
                table: "BookingServices");

            migrationBuilder.DropForeignKey(
                name: "FK_BookingServices_StatusItems_StatusItemID",
                table: "BookingServices");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleInvoices_BookingServices_BookingID",
                table: "SaleInvoices");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleInvoices_StatusForSale_StatusSaleID",
                table: "SaleInvoices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookingServices",
                table: "BookingServices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StatusForSale",
                table: "StatusForSale");

            migrationBuilder.RenameTable(
                name: "BookingServices",
                newName: "bookingServices");

            migrationBuilder.RenameTable(
                name: "StatusForSale",
                newName: "statusForSales");

            migrationBuilder.RenameIndex(
                name: "IX_BookingServices_StatusItemID",
                table: "bookingServices",
                newName: "IX_bookingServices_StatusItemID");

            migrationBuilder.RenameIndex(
                name: "IX_BookingServices_IdEM",
                table: "bookingServices",
                newName: "IX_bookingServices_IdEM");

            migrationBuilder.AddPrimaryKey(
                name: "PK_bookingServices",
                table: "bookingServices",
                column: "BookingID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_statusForSales",
                table: "statusForSales",
                column: "StatusSaleID");

            migrationBuilder.AddForeignKey(
                name: "FK_bookingServices_EmployeesDatas_IdEM",
                table: "bookingServices",
                column: "IdEM",
                principalTable: "EmployeesDatas",
                principalColumn: "IdEm",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_bookingServices_StatusItems_StatusItemID",
                table: "bookingServices",
                column: "StatusItemID",
                principalTable: "StatusItems",
                principalColumn: "StatusItemID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleInvoices_bookingServices_BookingID",
                table: "SaleInvoices",
                column: "BookingID",
                principalTable: "bookingServices",
                principalColumn: "BookingID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleInvoices_statusForSales_StatusSaleID",
                table: "SaleInvoices",
                column: "StatusSaleID",
                principalTable: "statusForSales",
                principalColumn: "StatusSaleID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bookingServices_EmployeesDatas_IdEM",
                table: "bookingServices");

            migrationBuilder.DropForeignKey(
                name: "FK_bookingServices_StatusItems_StatusItemID",
                table: "bookingServices");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleInvoices_bookingServices_BookingID",
                table: "SaleInvoices");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleInvoices_statusForSales_StatusSaleID",
                table: "SaleInvoices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_bookingServices",
                table: "bookingServices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_statusForSales",
                table: "statusForSales");

            migrationBuilder.RenameTable(
                name: "bookingServices",
                newName: "BookingServices");

            migrationBuilder.RenameTable(
                name: "statusForSales",
                newName: "StatusForSale");

            migrationBuilder.RenameIndex(
                name: "IX_bookingServices_StatusItemID",
                table: "BookingServices",
                newName: "IX_BookingServices_StatusItemID");

            migrationBuilder.RenameIndex(
                name: "IX_bookingServices_IdEM",
                table: "BookingServices",
                newName: "IX_BookingServices_IdEM");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookingServices",
                table: "BookingServices",
                column: "BookingID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StatusForSale",
                table: "StatusForSale",
                column: "StatusSaleID");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingServices_EmployeesDatas_IdEM",
                table: "BookingServices",
                column: "IdEM",
                principalTable: "EmployeesDatas",
                principalColumn: "IdEm",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookingServices_StatusItems_StatusItemID",
                table: "BookingServices",
                column: "StatusItemID",
                principalTable: "StatusItems",
                principalColumn: "StatusItemID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleInvoices_BookingServices_BookingID",
                table: "SaleInvoices",
                column: "BookingID",
                principalTable: "BookingServices",
                principalColumn: "BookingID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleInvoices_StatusForSale_StatusSaleID",
                table: "SaleInvoices",
                column: "StatusSaleID",
                principalTable: "StatusForSale",
                principalColumn: "StatusSaleID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
