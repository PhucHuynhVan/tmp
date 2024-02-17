using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clean.WinF.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ModifySewingMachineDto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CSAStitches",
                table: "SewingMachineConfiguration",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ETMLastAdjusted",
                table: "SewingMachineConfiguration",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StitchesAlreadySewn",
                table: "SewingMachineConfiguration",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ConnectedDevice",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    DeviceRoutingID = table.Column<int>(type: "INTEGER", nullable: false),
                    DeviceTypeID = table.Column<int>(type: "INTEGER", nullable: false),
                    PortID = table.Column<int>(type: "INTEGER", nullable: false),
                    IsExit = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConnectedDevice", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DeviceRouting",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceRouting", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DeviceType",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Port",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Port", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConnectedDevice");

            migrationBuilder.DropTable(
                name: "DeviceRouting");

            migrationBuilder.DropTable(
                name: "DeviceType");

            migrationBuilder.DropTable(
                name: "Port");

            migrationBuilder.DropColumn(
                name: "CSAStitches",
                table: "SewingMachineConfiguration");

            migrationBuilder.DropColumn(
                name: "ETMLastAdjusted",
                table: "SewingMachineConfiguration");

            migrationBuilder.DropColumn(
                name: "StitchesAlreadySewn",
                table: "SewingMachineConfiguration");
        }
    }
}
