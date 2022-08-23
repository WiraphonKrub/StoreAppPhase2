using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreAppPhase2.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeesDatas",
                columns: table => new
                {
                    IdEm = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstNameEm = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastNameEm = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SalaryEm = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AddressEm = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    RangeWorkingEm = table.Column<int>(type: "int", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeesDatas", x => x.IdEm);
                });

            migrationBuilder.CreateTable(
                name: "statusForSales",
                columns: table => new
                {
                    StatusSaleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusSaleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_statusForSales", x => x.StatusSaleID);
                });

            migrationBuilder.CreateTable(
                name: "StatusItems",
                columns: table => new
                {
                    StatusItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusItemName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusItems", x => x.StatusItemID);
                });

            migrationBuilder.CreateTable(
                name: "bookingServices",
                columns: table => new
                {
                    BookingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BookingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BookingPrices = table.Column<int>(type: "int", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdEM = table.Column<int>(type: "int", nullable: false),
                    StatusItemID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookingServices", x => x.BookingID);
                    table.ForeignKey(
                        name: "FK_bookingServices_EmployeesDatas_IdEM",
                        column: x => x.IdEM,
                        principalTable: "EmployeesDatas",
                        principalColumn: "IdEm",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bookingServices_StatusItems_StatusItemID",
                        column: x => x.StatusItemID,
                        principalTable: "StatusItems",
                        principalColumn: "StatusItemID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SaleInvoices",
                columns: table => new
                {
                    SaleInvoiceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusSaleID = table.Column<int>(type: "int", nullable: false),
                    BookingID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleInvoices", x => x.SaleInvoiceID);
                    table.ForeignKey(
                        name: "FK_SaleInvoices_bookingServices_BookingID",
                        column: x => x.BookingID,
                        principalTable: "bookingServices",
                        principalColumn: "BookingID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SaleInvoices_statusForSales_StatusSaleID",
                        column: x => x.StatusSaleID,
                        principalTable: "statusForSales",
                        principalColumn: "StatusSaleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_bookingServices_IdEM",
                table: "bookingServices",
                column: "IdEM");

            migrationBuilder.CreateIndex(
                name: "IX_bookingServices_StatusItemID",
                table: "bookingServices",
                column: "StatusItemID");

            migrationBuilder.CreateIndex(
                name: "IX_SaleInvoices_BookingID",
                table: "SaleInvoices",
                column: "BookingID");

            migrationBuilder.CreateIndex(
                name: "IX_SaleInvoices_StatusSaleID",
                table: "SaleInvoices",
                column: "StatusSaleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SaleInvoices");

            migrationBuilder.DropTable(
                name: "bookingServices");

            migrationBuilder.DropTable(
                name: "statusForSales");

            migrationBuilder.DropTable(
                name: "EmployeesDatas");

            migrationBuilder.DropTable(
                name: "StatusItems");
        }
    }
}
