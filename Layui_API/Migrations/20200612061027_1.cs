using Microsoft.EntityFrameworkCore.Migrations;

namespace Layui_API.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "classes",
                columns: table => new
                {
                    Mid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MName = table.Column<string>(nullable: true),
                    Mnumber = table.Column<int>(nullable: false),
                    ShippingRegion = table.Column<string>(nullable: true),
                    Administrator = table.Column<string>(nullable: true),
                    TheTeam = table.Column<string>(nullable: true)

                  //CId = table.Column<int>(nullable: false)
                  //      .Annotation("SqlServer:Identity", "1, 1"),
                  //  CName = table.Column<string>(nullable: true)          
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_classes", x => x.Mid);
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    Vid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VName = table.Column<string>(nullable: true),
                    VLicense = table.Column<string>(nullable: true),
                    VehiclePrices = table.Column<string>(nullable: true),
                    Vcolor = table.Column<string>(nullable: true),
                    VehicleFuel = table.Column<string>(nullable: true),
                    Emission = table.Column<string>(nullable: true),
                    VehicleStructure = table.Column<string>(nullable: true),
                    Mid = table.Column<int>(nullable: false)
                    //SId = table.Column<int>(nullable: false)
                    //    .Annotation("SqlServer:Identity", "1, 1"),
                    //Name = table.Column<string>(nullable: true),
                    //Sex = table.Column<bool>(nullable: false),
                    //CId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.Vid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "classes");

            migrationBuilder.DropTable(
                name: "students");
        }
    }
}
