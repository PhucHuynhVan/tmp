using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clean.WinF.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addAutomatDataForControl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "AutoLogout",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ControllDescription",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "MinETMMeasVal",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "SerialId",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AutoLogout",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "ControllDescription",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "MinETMMeasVal",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "SerialId",
                table: "Automat");
        }
    }
}
