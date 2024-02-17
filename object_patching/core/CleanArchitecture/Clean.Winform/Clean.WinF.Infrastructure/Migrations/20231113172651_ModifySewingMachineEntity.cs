using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clean.WinF.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ModifySewingMachineEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SerialNumber",
                table: "SewingMachineConfiguration",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SerialNumber",
                table: "SewingMachineConfiguration");
        }
    }
}
