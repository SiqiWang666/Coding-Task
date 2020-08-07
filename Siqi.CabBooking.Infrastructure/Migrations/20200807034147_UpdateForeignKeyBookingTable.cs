using Microsoft.EntityFrameworkCore.Migrations;

namespace Siqi.CabBooking.Infrastructure.Migrations
{
    public partial class UpdateForeignKeyBookingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ToPlaceId",
                table: "BookingHistory",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FromPlaceId",
                table: "BookingHistory",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookingHistory_CabTypeId",
                table: "BookingHistory",
                column: "CabTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingHistory_FromPlaceId",
                table: "BookingHistory",
                column: "FromPlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingHistory_ToPlaceId",
                table: "BookingHistory",
                column: "ToPlaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingHistory_CabType_CabTypeId",
                table: "BookingHistory",
                column: "CabTypeId",
                principalTable: "CabType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BookingHistory_Place_FromPlaceId",
                table: "BookingHistory",
                column: "FromPlaceId",
                principalTable: "Place",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BookingHistory_Place_ToPlaceId",
                table: "BookingHistory",
                column: "ToPlaceId",
                principalTable: "Place",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingHistory_CabType_CabTypeId",
                table: "BookingHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_BookingHistory_Place_FromPlaceId",
                table: "BookingHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_BookingHistory_Place_ToPlaceId",
                table: "BookingHistory");

            migrationBuilder.DropIndex(
                name: "IX_BookingHistory_CabTypeId",
                table: "BookingHistory");

            migrationBuilder.DropIndex(
                name: "IX_BookingHistory_FromPlaceId",
                table: "BookingHistory");

            migrationBuilder.DropIndex(
                name: "IX_BookingHistory_ToPlaceId",
                table: "BookingHistory");

            migrationBuilder.AlterColumn<int>(
                name: "ToPlaceId",
                table: "BookingHistory",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "FromPlaceId",
                table: "BookingHistory",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
