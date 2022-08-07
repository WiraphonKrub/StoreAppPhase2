using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreAppPhase2.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    IdEm = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstNameEm = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastNameEm = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SalaryEm = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AddressEm = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RangeWorkingEm = table.Column<int>(type: "int", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.IdEm);
                });

            migrationBuilder.CreateTable(
                name: "SellingEM",
                columns: table => new
                {
                    SellingEMID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceID = table.Column<int>(type: "int", nullable: false),
                    IdEM = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellingEM", x => x.SellingEMID);
                    table.ForeignKey(
                        name: "FK_SellingEM_Employees_IdEM",
                        column: x => x.IdEM,
                        principalTable: "Employees",
                        principalColumn: "IdEm",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SellingEM_IdEM",
                table: "SellingEM",
                column: "IdEM");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SellingEM");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
