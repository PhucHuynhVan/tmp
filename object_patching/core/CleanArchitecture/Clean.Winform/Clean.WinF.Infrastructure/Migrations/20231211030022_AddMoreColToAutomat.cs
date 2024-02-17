using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clean.WinF.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreColToAutomat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAutoLogout",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAutoLogout",
                table: "Automat");
        }
    }
}
