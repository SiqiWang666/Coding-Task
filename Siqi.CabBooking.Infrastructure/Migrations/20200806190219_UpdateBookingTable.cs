using Microsoft.EntityFrameworkCore.Migrations;

namespace Siqi.CabBooking.Infrastructure.Migrations
{
    public partial class UpdateBookingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Booking_CabTypeId",
                table: "Booking",
                column: "CabTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_CabType_CabTypeId",
                table: "Booking",
                column: "CabTypeId",
                principalTable: "CabType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_CabType_CabTypeId",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_CabTypeId",
                table: "Booking");
        }
    }
}
