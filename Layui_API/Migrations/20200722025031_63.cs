using Microsoft.EntityFrameworkCore.Migrations;

namespace Layui_API.Migrations
{
    public partial class _63 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_students",
                table: "students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_classes",
                table: "classes");

            migrationBuilder.DropColumn(
                name: "SId",
                table: "students");

            migrationBuilder.DropColumn(
                name: "CId",
                table: "students");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "students");

            migrationBuilder.DropColumn(
                name: "Sex",
                table: "students");

            migrationBuilder.DropColumn(
                name: "CId",
                table: "classes");

            migrationBuilder.DropColumn(
                name: "CName",
                table: "classes");

            migrationBuilder.AddColumn<int>(
                name: "Vid",
                table: "students",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Emission",
                table: "students",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Mid",
                table: "students",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "VLicense",
                table: "students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VName",
                table: "students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vcolor",
                table: "students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vehicle",
                table: "students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VehicleFuel",
                table: "students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VehiclePrices",
                table: "students",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Mid",
                table: "classes",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Administrator",
                table: "classes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MName",
                table: "classes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Mnumber",
                table: "classes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ShippingRegion",
                table: "classes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TheTeam",
                table: "classes",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_students",
                table: "students",
                column: "Vid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_classes",
                table: "classes",
                column: "Mid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_students",
                table: "students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_classes",
                table: "classes");

            migrationBuilder.DropColumn(
                name: "Vid",
                table: "students");

            migrationBuilder.DropColumn(
                name: "Emission",
                table: "students");

            migrationBuilder.DropColumn(
                name: "Mid",
                table: "students");

            migrationBuilder.DropColumn(
                name: "VLicense",
                table: "students");

            migrationBuilder.DropColumn(
                name: "VName",
                table: "students");

            migrationBuilder.DropColumn(
                name: "Vcolor",
                table: "students");

            migrationBuilder.DropColumn(
                name: "Vehicle",
                table: "students");

            migrationBuilder.DropColumn(
                name: "VehicleFuel",
                table: "students");

            migrationBuilder.DropColumn(
                name: "VehiclePrices",
                table: "students");

            migrationBuilder.DropColumn(
                name: "Mid",
                table: "classes");

            migrationBuilder.DropColumn(
                name: "Administrator",
                table: "classes");

            migrationBuilder.DropColumn(
                name: "MName",
                table: "classes");

            migrationBuilder.DropColumn(
                name: "Mnumber",
                table: "classes");

            migrationBuilder.DropColumn(
                name: "ShippingRegion",
                table: "classes");

            migrationBuilder.DropColumn(
                name: "TheTeam",
                table: "classes");

            migrationBuilder.AddColumn<int>(
                name: "SId",
                table: "students",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CId",
                table: "students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Sex",
                table: "students",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "CId",
                table: "classes",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "CName",
                table: "classes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_students",
                table: "students",
                column: "SId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_classes",
                table: "classes",
                column: "CId");
        }
    }
}
