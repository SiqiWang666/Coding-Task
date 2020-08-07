using Microsoft.EntityFrameworkCore.Migrations;

namespace Siqi.CabBooking.Infrastructure.Migrations
{
    public partial class ChangeForeignKeyConstrain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Charge",
                table: "BookingHistory",
                type: "DECIMAL(5,2)",
                nullable: true,
                defaultValue: 19.99m,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(5, 2)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Booking_FromPlaceId",
                table: "Booking",
                column: "FromPlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_ToPlaceId",
                table: "Booking",
                column: "ToPlaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Place_FromPlaceId",
                table: "Booking",
                column: "FromPlaceId",
                principalTable: "Place",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Place_ToPlaceId",
                table: "Booking",
                column: "ToPlaceId",
                principalTable: "Place",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Place_FromPlaceId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Place_ToPlaceId",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_FromPlaceId",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_ToPlaceId",
                table: "Booking");

            migrationBuilder.AlterColumn<decimal>(
                name: "Charge",
                table: "BookingHistory",
                type: "DECIMAL(5, 2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(5,2)",
                oldNullable: true,
                oldDefaultValue: 19.99m);
        }
    }
}
