using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clean.WinF.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateAutomat2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAllocationToAnArticleIsPossible",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "IsAutoTolCrit",
                table: "Automat");

            migrationBuilder.RenameColumn(
                name: "IsUpperThread",
                table: "Automat",
                newName: "UpperThread");

            migrationBuilder.RenameColumn(
                name: "IsPrintArticleLabelEnabled",
                table: "Automat",
                newName: "PrintArticleLabelEnabled");

            migrationBuilder.RenameColumn(
                name: "IsPart5",
                table: "Automat",
                newName: "Part5");

            migrationBuilder.RenameColumn(
                name: "IsPart4",
                table: "Automat",
                newName: "Part4");

            migrationBuilder.RenameColumn(
                name: "IsPart3",
                table: "Automat",
                newName: "Part3");

            migrationBuilder.RenameColumn(
                name: "IsPart2",
                table: "Automat",
                newName: "Part2");

            migrationBuilder.RenameColumn(
                name: "IsPart1",
                table: "Automat",
                newName: "Part1");

            migrationBuilder.RenameColumn(
                name: "IsLowerThread",
                table: "Automat",
                newName: "LowerThread");

            migrationBuilder.RenameColumn(
                name: "IsInfor7",
                table: "Automat",
                newName: "Infor7");

            migrationBuilder.RenameColumn(
                name: "IsInfor6",
                table: "Automat",
                newName: "Infor6");

            migrationBuilder.RenameColumn(
                name: "IsInfor5",
                table: "Automat",
                newName: "Infor5");

            migrationBuilder.RenameColumn(
                name: "IsInfor4",
                table: "Automat",
                newName: "Infor4");

            migrationBuilder.RenameColumn(
                name: "IsInfor3",
                table: "Automat",
                newName: "Infor3");

            migrationBuilder.RenameColumn(
                name: "IsInfor2",
                table: "Automat",
                newName: "Infor2");

            migrationBuilder.RenameColumn(
                name: "IsInfor1",
                table: "Automat",
                newName: "Infor1");

            migrationBuilder.RenameColumn(
                name: "IsExactLength7",
                table: "Automat",
                newName: "ExactLength7");

            migrationBuilder.RenameColumn(
                name: "IsExactLength6",
                table: "Automat",
                newName: "ExactLength6");

            migrationBuilder.RenameColumn(
                name: "IsExactLength5",
                table: "Automat",
                newName: "ExactLength5");

            migrationBuilder.RenameColumn(
                name: "IsExactLength4",
                table: "Automat",
                newName: "ExactLength4");

            migrationBuilder.RenameColumn(
                name: "IsExactLength3",
                table: "Automat",
                newName: "ExactLength3");

            migrationBuilder.RenameColumn(
                name: "IsExactLength2",
                table: "Automat",
                newName: "ExactLength2");

            migrationBuilder.RenameColumn(
                name: "IsExactLength1",
                table: "Automat",
                newName: "ExactLength1");

            migrationBuilder.RenameColumn(
                name: "IsEnableStitchLength",
                table: "Automat",
                newName: "EnableStitchLength");

            migrationBuilder.RenameColumn(
                name: "IsETM14600ValuesAreEditable",
                table: "Automat",
                newName: "ETM14600ValuesAreEditable");

            migrationBuilder.RenameColumn(
                name: "IsCustom",
                table: "Automat",
                newName: "Custom");

            migrationBuilder.RenameColumn(
                name: "IsAutoTolNotCrit",
                table: "Automat",
                newName: "AllocationToAnArticleIsPossible");

            migrationBuilder.AlterColumn<bool>(
                name: "AutoTolNotCrit",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "AutoTolCrit",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AutoTolCritText",
                table: "Automat",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AutoTolNotCritText",
                table: "Automat",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AutoTolCritText",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "AutoTolNotCritText",
                table: "Automat");

            migrationBuilder.RenameColumn(
                name: "UpperThread",
                table: "Automat",
                newName: "IsUpperThread");

            migrationBuilder.RenameColumn(
                name: "PrintArticleLabelEnabled",
                table: "Automat",
                newName: "IsPrintArticleLabelEnabled");

            migrationBuilder.RenameColumn(
                name: "Part5",
                table: "Automat",
                newName: "IsPart5");

            migrationBuilder.RenameColumn(
                name: "Part4",
                table: "Automat",
                newName: "IsPart4");

            migrationBuilder.RenameColumn(
                name: "Part3",
                table: "Automat",
                newName: "IsPart3");

            migrationBuilder.RenameColumn(
                name: "Part2",
                table: "Automat",
                newName: "IsPart2");

            migrationBuilder.RenameColumn(
                name: "Part1",
                table: "Automat",
                newName: "IsPart1");

            migrationBuilder.RenameColumn(
                name: "LowerThread",
                table: "Automat",
                newName: "IsLowerThread");

            migrationBuilder.RenameColumn(
                name: "Infor7",
                table: "Automat",
                newName: "IsInfor7");

            migrationBuilder.RenameColumn(
                name: "Infor6",
                table: "Automat",
                newName: "IsInfor6");

            migrationBuilder.RenameColumn(
                name: "Infor5",
                table: "Automat",
                newName: "IsInfor5");

            migrationBuilder.RenameColumn(
                name: "Infor4",
                table: "Automat",
                newName: "IsInfor4");

            migrationBuilder.RenameColumn(
                name: "Infor3",
                table: "Automat",
                newName: "IsInfor3");

            migrationBuilder.RenameColumn(
                name: "Infor2",
                table: "Automat",
                newName: "IsInfor2");

            migrationBuilder.RenameColumn(
                name: "Infor1",
                table: "Automat",
                newName: "IsInfor1");

            migrationBuilder.RenameColumn(
                name: "ExactLength7",
                table: "Automat",
                newName: "IsExactLength7");

            migrationBuilder.RenameColumn(
                name: "ExactLength6",
                table: "Automat",
                newName: "IsExactLength6");

            migrationBuilder.RenameColumn(
                name: "ExactLength5",
                table: "Automat",
                newName: "IsExactLength5");

            migrationBuilder.RenameColumn(
                name: "ExactLength4",
                table: "Automat",
                newName: "IsExactLength4");

            migrationBuilder.RenameColumn(
                name: "ExactLength3",
                table: "Automat",
                newName: "IsExactLength3");

            migrationBuilder.RenameColumn(
                name: "ExactLength2",
                table: "Automat",
                newName: "IsExactLength2");

            migrationBuilder.RenameColumn(
                name: "ExactLength1",
                table: "Automat",
                newName: "IsExactLength1");

            migrationBuilder.RenameColumn(
                name: "EnableStitchLength",
                table: "Automat",
                newName: "IsEnableStitchLength");

            migrationBuilder.RenameColumn(
                name: "ETM14600ValuesAreEditable",
                table: "Automat",
                newName: "IsETM14600ValuesAreEditable");

            migrationBuilder.RenameColumn(
                name: "Custom",
                table: "Automat",
                newName: "IsCustom");

            migrationBuilder.RenameColumn(
                name: "AllocationToAnArticleIsPossible",
                table: "Automat",
                newName: "IsAutoTolNotCrit");

            migrationBuilder.AlterColumn<string>(
                name: "AutoTolNotCrit",
                table: "Automat",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "AutoTolCrit",
                table: "Automat",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<bool>(
                name: "IsAllocationToAnArticleIsPossible",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsAutoTolCrit",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }
    }
}
