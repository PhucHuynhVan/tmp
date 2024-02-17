using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clean.WinF.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ModifyRoleAndPermissionTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserGroup_Permission_PermissionID",
                table: "UserGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_UserGroup_Role_RoleID",
                table: "UserGroup");

            migrationBuilder.DropIndex(
                name: "IX_UserGroup_PermissionID",
                table: "UserGroup");

            migrationBuilder.DropIndex(
                name: "IX_UserGroup_RoleID",
                table: "UserGroup");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_UserGroup_PermissionID",
                table: "UserGroup",
                column: "PermissionID");

            migrationBuilder.CreateIndex(
                name: "IX_UserGroup_RoleID",
                table: "UserGroup",
                column: "RoleID");

            migrationBuilder.AddForeignKey(
                name: "FK_UserGroup_Permission_PermissionID",
                table: "UserGroup",
                column: "PermissionID",
                principalTable: "Permission",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserGroup_Role_RoleID",
                table: "UserGroup",
                column: "RoleID",
                principalTable: "Role",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
