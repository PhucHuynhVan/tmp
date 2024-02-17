using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace Clean.WinF.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddSerialNumberTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CounterType",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CounterType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ResetType",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResetType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SerialNumber",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    InternalName = table.Column<string>(type: "TEXT", nullable: true),
                    CounterTypeName = table.Column<string>(type: "TEXT", nullable: true),
                    ResetTypeName = table.Column<string>(type: "TEXT", nullable: true),
                    CurrentSerialNumber = table.Column<long>(type: "INTEGER", nullable: false),
                    ResetDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    MaximumValue = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SerialNumber", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CounterType");

            migrationBuilder.DropTable(
                name: "ResetType");

            migrationBuilder.DropTable(
                name: "SerialNumber");
        }
    }
}
