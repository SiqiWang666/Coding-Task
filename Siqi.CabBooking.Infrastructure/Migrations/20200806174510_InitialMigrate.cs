using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Siqi.CabBooking.Infrastructure.Migrations
{
    public partial class InitialMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    BookingDate = table.Column<DateTime>(nullable: true),
                    BookingTime = table.Column<DateTime>(nullable: true),
                    FromPlaceId = table.Column<int>(nullable: true),
                    ToPlaceId = table.Column<int>(nullable: true),
                    PickupAddress = table.Column<string>(maxLength: 200, nullable: true),
                    Landmark = table.Column<string>(nullable: true),
                    PickupDate = table.Column<DateTime>(nullable: true),
                    PickupTime = table.Column<DateTime>(nullable: true),
                    CabTypeId = table.Column<int>(nullable: true),
                    ContactNo = table.Column<string>(maxLength: 25, nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookingHistory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    BookingDate = table.Column<DateTime>(nullable: true),
                    BookingTime = table.Column<DateTime>(nullable: true),
                    FromPlaceId = table.Column<int>(nullable: true),
                    ToPlaceId = table.Column<int>(nullable: true),
                    PickupAddress = table.Column<string>(maxLength: 200, nullable: true),
                    Landmark = table.Column<string>(nullable: true),
                    PickupDate = table.Column<DateTime>(nullable: true),
                    PickupTime = table.Column<DateTime>(nullable: true),
                    CabTypeId = table.Column<int>(nullable: true),
                    ContactNo = table.Column<string>(maxLength: 25, nullable: true),
                    Status = table.Column<string>(nullable: true),
                    CompTime = table.Column<string>(nullable: true),
                    Charge = table.Column<decimal>(type: "DECIMAL(5, 2)", nullable: true),
                    Feedback = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingHistory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CabType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CabTypeName = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CabType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Place",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlaceName = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Place", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "BookingHistory");

            migrationBuilder.DropTable(
                name: "CabType");

            migrationBuilder.DropTable(
                name: "Place");
        }
    }
}
