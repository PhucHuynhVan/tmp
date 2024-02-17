using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clean.WinF.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateAutomat3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Infor7",
                table: "Automat",
                newName: "Info7");

            migrationBuilder.RenameColumn(
                name: "Infor6",
                table: "Automat",
                newName: "Info6");

            migrationBuilder.RenameColumn(
                name: "Infor5",
                table: "Automat",
                newName: "Info5");

            migrationBuilder.RenameColumn(
                name: "Infor4",
                table: "Automat",
                newName: "Info4");

            migrationBuilder.RenameColumn(
                name: "Infor3",
                table: "Automat",
                newName: "Info3");

            migrationBuilder.RenameColumn(
                name: "Infor2",
                table: "Automat",
                newName: "Info2");

            migrationBuilder.RenameColumn(
                name: "Infor1",
                table: "Automat",
                newName: "Info1");

            migrationBuilder.AlterColumn<bool>(
                name: "ArticleCodeExactLength",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Info7",
                table: "Automat",
                newName: "Infor7");

            migrationBuilder.RenameColumn(
                name: "Info6",
                table: "Automat",
                newName: "Infor6");

            migrationBuilder.RenameColumn(
                name: "Info5",
                table: "Automat",
                newName: "Infor5");

            migrationBuilder.RenameColumn(
                name: "Info4",
                table: "Automat",
                newName: "Infor4");

            migrationBuilder.RenameColumn(
                name: "Info3",
                table: "Automat",
                newName: "Infor3");

            migrationBuilder.RenameColumn(
                name: "Info2",
                table: "Automat",
                newName: "Infor2");

            migrationBuilder.RenameColumn(
                name: "Info1",
                table: "Automat",
                newName: "Infor1");

            migrationBuilder.AlterColumn<string>(
                name: "ArticleCodeExactLength",
                table: "Automat",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "INTEGER");
        }
    }
}
