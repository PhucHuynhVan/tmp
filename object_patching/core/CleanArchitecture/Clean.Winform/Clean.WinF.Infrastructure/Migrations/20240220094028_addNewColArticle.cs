using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clean.WinF.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addNewColArticle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BacktackEndEndlabelSeamBackward",
                table: "Article",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BacktackEndEndlabelSeamForward",
                table: "Article",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BacktackEndFreeSeamBackward",
                table: "Article",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BacktackEndFreeSeamForward",
                table: "Article",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BacktackEndSABSeamBackward",
                table: "Article",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BacktackEndSABSeamForward",
                table: "Article",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BacktackStartEndlabelSeamBackward",
                table: "Article",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BacktackStartEndlabelSeamForward",
                table: "Article",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BacktackStartFreeSeamBackward",
                table: "Article",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BacktackStartFreeSeamForward",
                table: "Article",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BacktackStartSABSeamBackward",
                table: "Article",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BacktackStartSABSeamForward",
                table: "Article",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MonitoringEndlabelSeam",
                table: "Article",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MonitoringFreeSeam",
                table: "Article",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MonitoringSeaction1",
                table: "Article",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MonitoringSeaction3",
                table: "Article",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BacktackEndEndlabelSeamBackward",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "BacktackEndEndlabelSeamForward",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "BacktackEndFreeSeamBackward",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "BacktackEndFreeSeamForward",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "BacktackEndSABSeamBackward",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "BacktackEndSABSeamForward",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "BacktackStartEndlabelSeamBackward",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "BacktackStartEndlabelSeamForward",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "BacktackStartFreeSeamBackward",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "BacktackStartFreeSeamForward",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "BacktackStartSABSeamBackward",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "BacktackStartSABSeamForward",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "MonitoringEndlabelSeam",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "MonitoringFreeSeam",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "MonitoringSeaction1",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "MonitoringSeaction3",
                table: "Article");
        }
    }
}
