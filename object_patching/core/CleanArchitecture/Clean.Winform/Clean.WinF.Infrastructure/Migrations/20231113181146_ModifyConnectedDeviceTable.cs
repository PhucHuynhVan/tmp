using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clean.WinF.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ModifyConnectedDeviceTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ZebraScannerSerialNumber",
                table: "ConnectedDevice",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ZebraScannerSerialNumber",
                table: "ConnectedDevice");
        }
    }
}
