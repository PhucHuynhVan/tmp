using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clean.WinF.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateAutomat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ArticleCodeExactLength",
                table: "Automat",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ArticleCodeMaxLength",
                table: "Automat",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AutoTolCrit",
                table: "Automat",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AutoTolNotCrit",
                table: "Automat",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ETM14600",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ETM422",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "EnableStitchLengthMax",
                table: "Automat",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EnableStitchLengthMin",
                table: "Automat",
                type: "TEXT",
                nullable: true);

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

            migrationBuilder.AddColumn<bool>(
                name: "IsAutoTolNotCrit",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsCustom",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsETM14600ValuesAreEditable",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsEnableStitchLength",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsExactLength1",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsExactLength2",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsExactLength3",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsExactLength4",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsExactLength5",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsExactLength6",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsExactLength7",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsInfor1",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsInfor2",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsInfor3",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsInfor4",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsInfor5",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsInfor6",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsInfor7",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsLowerThread",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPart1",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPart2",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPart3",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPart4",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPart5",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPrintArticleLabelEnabled",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsUpperThread",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LabelText1",
                table: "Automat",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LabelText2",
                table: "Automat",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LabelText3",
                table: "Automat",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LabelText4",
                table: "Automat",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LabelText5",
                table: "Automat",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LabelText6",
                table: "Automat",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LabelText7",
                table: "Automat",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "OneCriticalSectionNoSeamsWithEndLabel",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "OneCriticalSectionNoSeamsWithFLPart",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "OneCriticalSectionTwoSeamsWithEndLabel",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "OneCriticalSectionTwoSeamsWithEndLabelBehind",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "OneCriticalSectionTwoSeamsWithFLPart",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "OneCriticalSectionTwoSeamsWithTwoEndLabel",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ThreeCriticalSectionFourSeamsWithEndLabel",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ThreeCriticalSectionFourSeamsWithEndLabelBehind",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ThreeCriticalSectionFourSeamsWithFLPart",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ThreeCriticalSectionFourSeamsWithTwoEndLabel",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ThreeCriticalSectionTwoSeamsWithEndLabel",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ThreeCriticalSectionTwoSeamsWithFLPart",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TwoCriticalSectionFourSeamsWithEndLabel",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TwoCriticalSectionFourSeamsWithEndLabelBehind",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TwoCriticalSectionFourSeamsWithFLPart",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TwoCriticalSectionFourSeamsWithTwoEndLabel",
                table: "Automat",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArticleCodeExactLength",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "ArticleCodeMaxLength",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "AutoTolCrit",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "AutoTolNotCrit",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "ETM14600",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "ETM422",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "EnableStitchLengthMax",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "EnableStitchLengthMin",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "IsAllocationToAnArticleIsPossible",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "IsAutoTolCrit",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "IsAutoTolNotCrit",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "IsCustom",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "IsETM14600ValuesAreEditable",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "IsEnableStitchLength",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "IsExactLength1",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "IsExactLength2",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "IsExactLength3",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "IsExactLength4",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "IsExactLength5",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "IsExactLength6",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "IsExactLength7",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "IsInfor1",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "IsInfor2",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "IsInfor3",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "IsInfor4",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "IsInfor5",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "IsInfor6",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "IsInfor7",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "IsLowerThread",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "IsPart1",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "IsPart2",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "IsPart3",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "IsPart4",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "IsPart5",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "IsPrintArticleLabelEnabled",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "IsUpperThread",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "LabelText1",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "LabelText2",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "LabelText3",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "LabelText4",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "LabelText5",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "LabelText6",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "LabelText7",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "OneCriticalSectionNoSeamsWithEndLabel",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "OneCriticalSectionNoSeamsWithFLPart",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "OneCriticalSectionTwoSeamsWithEndLabel",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "OneCriticalSectionTwoSeamsWithEndLabelBehind",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "OneCriticalSectionTwoSeamsWithFLPart",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "OneCriticalSectionTwoSeamsWithTwoEndLabel",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "ThreeCriticalSectionFourSeamsWithEndLabel",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "ThreeCriticalSectionFourSeamsWithEndLabelBehind",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "ThreeCriticalSectionFourSeamsWithFLPart",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "ThreeCriticalSectionFourSeamsWithTwoEndLabel",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "ThreeCriticalSectionTwoSeamsWithEndLabel",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "ThreeCriticalSectionTwoSeamsWithFLPart",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "TwoCriticalSectionFourSeamsWithEndLabel",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "TwoCriticalSectionFourSeamsWithEndLabelBehind",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "TwoCriticalSectionFourSeamsWithFLPart",
                table: "Automat");

            migrationBuilder.DropColumn(
                name: "TwoCriticalSectionFourSeamsWithTwoEndLabel",
                table: "Automat");
        }
    }
}
