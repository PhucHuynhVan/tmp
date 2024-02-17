using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace Clean.WinF.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ModifyComputer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Setting_ComputerConfiguration_ComputersID",
                table: "Setting");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ComputerConfiguration",
                table: "ComputerConfiguration");

            migrationBuilder.DropColumn(
                name: "ArchieveAllProtocolAfterDays",
                table: "ComputerConfiguration");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ComputerConfiguration");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "ComputerConfiguration");

            migrationBuilder.DropColumn(
                name: "InterfaceBarcodePrinter",
                table: "ComputerConfiguration");

            migrationBuilder.DropColumn(
                name: "LanguageForBiasysControlName",
                table: "ComputerConfiguration");

            migrationBuilder.DropColumn(
                name: "LanguageForBiasysDBName",
                table: "ComputerConfiguration");

            migrationBuilder.DropColumn(
                name: "LocationOfArchievedProtocolDatabases",
                table: "ComputerConfiguration");

            migrationBuilder.DropColumn(
                name: "LocationOfArchievedProtocolFilesWriteByBiasysControl",
                table: "ComputerConfiguration");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "ComputerConfiguration");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "ComputerConfiguration");

            migrationBuilder.RenameTable(
                name: "ComputerConfiguration",
                newName: "Computer");

            migrationBuilder.AlterColumn<string>(
                name: "Permission",
                table: "SystemConfiguration",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "INTEGER");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Computer",
                table: "Computer",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Setting_Computer_ComputersID",
                table: "Setting",
                column: "ComputersID",
                principalTable: "Computer",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Setting_Computer_ComputersID",
                table: "Setting");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Computer",
                table: "Computer");

            migrationBuilder.RenameTable(
                name: "Computer",
                newName: "ComputerConfiguration");

            migrationBuilder.AlterColumn<bool>(
                name: "Permission",
                table: "SystemConfiguration",
                type: "INTEGER",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ArchieveAllProtocolAfterDays",
                table: "ComputerConfiguration",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "ComputerConfiguration",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "ComputerConfiguration",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "InterfaceBarcodePrinter",
                table: "ComputerConfiguration",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LanguageForBiasysControlName",
                table: "ComputerConfiguration",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LanguageForBiasysDBName",
                table: "ComputerConfiguration",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LocationOfArchievedProtocolDatabases",
                table: "ComputerConfiguration",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LocationOfArchievedProtocolFilesWriteByBiasysControl",
                table: "ComputerConfiguration",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "ComputerConfiguration",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "ComputerConfiguration",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_ComputerConfiguration",
                table: "ComputerConfiguration",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Setting_ComputerConfiguration_ComputersID",
                table: "Setting",
                column: "ComputersID",
                principalTable: "ComputerConfiguration",
                principalColumn: "ID");
        }
    }
}
