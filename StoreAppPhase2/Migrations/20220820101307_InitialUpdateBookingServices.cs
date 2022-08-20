using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreAppPhase2.Migrations
{
    public partial class InitialUpdateBookingServices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookingServices",
                columns: table => new
                {
                    BookingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DueDate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StatusItemID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingServices", x => x.BookingID);
                    table.ForeignKey(
                        name: "FK_BookingServices_StatusItems_StatusItemID",
                        column: x => x.StatusItemID,
                        principalTable: "StatusItems",
                        principalColumn: "StatusItemID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookingServices_StatusItemID",
                table: "BookingServices",
                column: "StatusItemID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookingServices");
        }
    }
}
