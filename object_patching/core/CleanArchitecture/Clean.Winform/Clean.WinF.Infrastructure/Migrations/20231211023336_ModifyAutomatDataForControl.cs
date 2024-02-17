using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clean.WinF.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ModifyAutomatDataForControl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ControllDescription",
                table: "Automat",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "INTEGER");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "ControllDescription",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }
    }
}
