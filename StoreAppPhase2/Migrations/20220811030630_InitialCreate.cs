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
                name: "SaleInvoices",
                columns: table => new
                {
                    SaleInvoiceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceNo = table.Column<int>(type: "int", nullable: false),
                    StatusItemID = table.Column<int>(type: "int", nullable: false),
                    IdEM = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleInvoices", x => x.SaleInvoiceID);
                    table.ForeignKey(
                        name: "FK_SaleInvoices_EmployeesDatas_IdEM",
                        column: x => x.IdEM,
                        principalTable: "EmployeesDatas",
                        principalColumn: "IdEm",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SaleInvoices_StatusItems_StatusItemID",
                        column: x => x.StatusItemID,
                        principalTable: "StatusItems",
                        principalColumn: "StatusItemID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SaleInvoices_IdEM",
                table: "SaleInvoices",
                column: "IdEM");

            migrationBuilder.CreateIndex(
                name: "IX_SaleInvoices_StatusItemID",
                table: "SaleInvoices",
                column: "StatusItemID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SaleInvoices");

            migrationBuilder.DropTable(
                name: "EmployeesDatas");

            migrationBuilder.DropTable(
                name: "StatusItems");
        }
    }
}
