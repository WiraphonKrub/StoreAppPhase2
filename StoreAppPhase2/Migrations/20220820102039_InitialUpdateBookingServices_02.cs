using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreAppPhase2.Migrations
{
    public partial class InitialUpdateBookingServices_02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemID",
                table: "BookingServices");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ItemID",
                table: "BookingServices",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
