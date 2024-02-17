using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace Clean.WinF.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrationChanges00 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppCodeGUIDefinition",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AppID = table.Column<int>(type: "INTEGER", nullable: false),
                    CodeGroupGUI = table.Column<string>(type: "TEXT", nullable: true),
                    CodeGUI = table.Column<string>(type: "TEXT", nullable: true),
                    ObjectType = table.Column<string>(type: "TEXT", nullable: true),
                    Languages = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppCodeGUIDefinition", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AppDefinition",
                columns: table => new
                {
                    AppID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppDefinition", x => x.AppID);
                });

            migrationBuilder.CreateTable(
                name: "AppGroupGUIDefinition",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AppID = table.Column<int>(type: "INTEGER", nullable: false),
                    CodeGroup = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppGroupGUIDefinition", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Automat",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Code = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Automat", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Bobbin",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BobbinNo = table.Column<int>(type: "INTEGER", nullable: false),
                    BobbinLabel = table.Column<string>(type: "TEXT", nullable: true),
                    ThreadLabel = table.Column<string>(type: "TEXT", nullable: true),
                    StitchCount = table.Column<string>(type: "TEXT", nullable: true),
                    Machine = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bobbin", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ChangeOfNeedlesRecords",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MachineNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    UserID = table.Column<long>(type: "INTEGER", nullable: false),
                    StitchCount = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChangeOfNeedlesRecords", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ClipSenSorActivation",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClipSenSorActivation", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ComputerConfiguration",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    MachineNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    LanguageForBiasysControlName = table.Column<string>(type: "TEXT", nullable: true),
                    LanguageForBiasysDBName = table.Column<string>(type: "TEXT", nullable: true),
                    InterfaceBarcodePrinter = table.Column<string>(type: "TEXT", nullable: true),
                    ArchieveAllProtocolAfterDays = table.Column<int>(type: "INTEGER", nullable: false),
                    LocationOfArchievedProtocolDatabases = table.Column<string>(type: "TEXT", nullable: true),
                    LocationOfArchievedProtocolFilesWriteByBiasysControl = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComputerConfiguration", x => x.ID);
                });

            //migrationBuilder.CreateTable(
            //    name: "DBLog",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "INTEGER", nullable: false)
            //            .Annotation("Sqlite:Autoincrement", true),
            //        TimeStamp = table.Column<string>(type: "TEXT", nullable: true),
            //        Level = table.Column<string>(type: "TEXT", nullable: true),
            //        RenderedMessage = table.Column<string>(type: "TEXT", nullable: true),
            //        Exception = table.Column<string>(type: "TEXT", nullable: true),
            //        Properties = table.Column<string>(type: "TEXT", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_DBLog", x => x.Id);
            //    });

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Code = table.Column<string>(type: "TEXT", nullable: true),
                    Lang = table.Column<string>(type: "TEXT", nullable: true),
                    DisplayCode = table.Column<string>(type: "TEXT", nullable: true),
                    IconImg = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ParentName = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Tag = table.Column<string>(type: "TEXT", nullable: true),
                    IconImg = table.Column<string>(type: "TEXT", nullable: true),
                    Desciption = table.Column<string>(type: "TEXT", nullable: true),
                    Languages = table.Column<string>(type: "TEXT", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderNo = table.Column<string>(type: "TEXT", nullable: true),
                    ArticleCode = table.Column<string>(type: "TEXT", nullable: true),
                    ArticleName = table.Column<string>(type: "TEXT", nullable: true),
                    OrderQuantity = table.Column<int>(type: "INTEGER", nullable: false),
                    ActualQuantity = table.Column<int>(type: "INTEGER", nullable: false),
                    SABLabel = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Part",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Code = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Info1 = table.Column<string>(type: "TEXT", nullable: true),
                    Info2 = table.Column<string>(type: "TEXT", nullable: true),
                    Info3 = table.Column<string>(type: "TEXT", nullable: true),
                    Info4 = table.Column<string>(type: "TEXT", nullable: true),
                    Info5 = table.Column<string>(type: "TEXT", nullable: true),
                    SABLabel = table.Column<string>(type: "TEXT", nullable: true),
                    LabelDefinition = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Part", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Permission",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Code = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permission", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Protocol",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Label = table.Column<string>(type: "TEXT", nullable: false),
                    EndLabel = table.Column<string>(type: "TEXT", nullable: false),
                    SerialNo = table.Column<string>(type: "TEXT", nullable: false),
                    SeamOK = table.Column<bool>(type: "INTEGER", nullable: false),
                    SeamDetailStatus = table.Column<bool>(type: "INTEGER", nullable: false),
                    EndLabelSeamed1 = table.Column<string>(type: "TEXT", nullable: true),
                    EndLabe2Seamed = table.Column<string>(type: "TEXT", nullable: true),
                    StitchesCrit1 = table.Column<string>(type: "TEXT", nullable: true),
                    StitchesNotCrit1 = table.Column<string>(type: "TEXT", nullable: true),
                    StitchesCrit2 = table.Column<string>(type: "TEXT", nullable: true),
                    StitchesNotCrit2 = table.Column<string>(type: "TEXT", nullable: true),
                    StitchesCrit3 = table.Column<string>(type: "TEXT", nullable: true),
                    StitchesNotCrit4 = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Protocol", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Report",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Path = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Report", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SewingMachineConfiguration",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MachineNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    AlternativeMachine = table.Column<int>(type: "INTEGER", nullable: false),
                    ActivatedFootLiftinCriticalSection = table.Column<bool>(type: "INTEGER", nullable: false),
                    MaxNoStitchesPerNeedles = table.Column<int>(type: "INTEGER", nullable: false),
                    ClipSensorActivationName = table.Column<string>(type: "TEXT", nullable: true),
                    OnAfterMinStitchesminusXStitch = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SewingMachineConfiguration", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SewingMachineParameter",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ArticleID = table.Column<long>(type: "INTEGER", nullable: false),
                    StitchLength = table.Column<string>(type: "TEXT", nullable: true),
                    NonCriticalSection = table.Column<string>(type: "TEXT", nullable: true),
                    CriticalSection = table.Column<string>(type: "TEXT", nullable: true),
                    MinTolerance = table.Column<string>(type: "TEXT", nullable: true),
                    ReferenceTension = table.Column<string>(type: "TEXT", nullable: true),
                    MaxTolerance = table.Column<string>(type: "TEXT", nullable: true),
                    StopFilter = table.Column<string>(type: "TEXT", nullable: true),
                    StartMonitoring = table.Column<string>(type: "TEXT", nullable: true),
                    StitchForwardSeam1Front = table.Column<string>(type: "TEXT", nullable: true),
                    StitchBackwardSeam1Front = table.Column<string>(type: "TEXT", nullable: true),
                    RepetitionSeam1Front = table.Column<string>(type: "TEXT", nullable: true),
                    StitchForwardSeam2Front = table.Column<string>(type: "TEXT", nullable: true),
                    StitchBackwardSeam2Front = table.Column<string>(type: "TEXT", nullable: true),
                    RepetitionSeam2Front = table.Column<string>(type: "TEXT", nullable: true),
                    StitchForwardSeam1End = table.Column<string>(type: "TEXT", nullable: true),
                    StitchBackwardSeam1End = table.Column<string>(type: "TEXT", nullable: true),
                    RepetitionSeam1End = table.Column<string>(type: "TEXT", nullable: true),
                    StitchForwardSeam2End = table.Column<string>(type: "TEXT", nullable: true),
                    StitchBackwardSeam2End = table.Column<string>(type: "TEXT", nullable: true),
                    RepetitionSeam2End = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SewingMachineParameter", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Code = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Street = table.Column<string>(type: "TEXT", nullable: true),
                    Zip = table.Column<string>(type: "TEXT", nullable: true),
                    Place = table.Column<string>(type: "TEXT", nullable: true),
                    Telephone = table.Column<string>(type: "TEXT", nullable: true),
                    Fax = table.Column<string>(type: "TEXT", nullable: true),
                    Remark = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SystemConfiguration",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FeatureKey = table.Column<string>(type: "TEXT", nullable: true),
                    Permission = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemConfiguration", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Thread",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Code = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Colour = table.Column<string>(type: "TEXT", nullable: true),
                    WindingParameterName = table.Column<string>(type: "TEXT", nullable: true),
                    NeedleThread = table.Column<bool>(type: "INTEGER", nullable: false),
                    BobbinThread = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Thread", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    Telephone = table.Column<string>(type: "TEXT", nullable: true),
                    UserID = table.Column<string>(type: "TEXT", nullable: true),
                    Password = table.Column<string>(type: "TEXT", nullable: true),
                    WinAccount01 = table.Column<string>(type: "TEXT", nullable: true),
                    WinAccount02 = table.Column<string>(type: "TEXT", nullable: true),
                    LoginAllowed = table.Column<bool>(type: "INTEGER", nullable: false),
                    FingerDataAvailable = table.Column<bool>(type: "INTEGER", nullable: false),
                    FirstFinger = table.Column<string>(type: "TEXT", nullable: true),
                    SecondFinger = table.Column<string>(type: "TEXT", nullable: true),
                    ThirdFinger = table.Column<string>(type: "TEXT", nullable: true),
                    UserImage = table.Column<string>(type: "TEXT", nullable: true),
                    RoleID = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WindingParamter",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    NeedleThread = table.Column<bool>(type: "INTEGER", nullable: false),
                    BobbinThread = table.Column<bool>(type: "INTEGER", nullable: false),
                    StitchesOnFullBobbin = table.Column<string>(type: "TEXT", nullable: true),
                    WindingDurationOnMachine = table.Column<string>(type: "TEXT", nullable: true),
                    Remark = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WindingParamter", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Setting",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ComputerName = table.Column<string>(type: "TEXT", nullable: true),
                    LanguageBiasysControl = table.Column<string>(type: "TEXT", nullable: true),
                    LanguageBiasysDB = table.Column<string>(type: "TEXT", nullable: true),
                    Port = table.Column<string>(type: "TEXT", nullable: true),
                    PathOfBiasysControl = table.Column<string>(type: "TEXT", nullable: true),
                    PathOfProtocolDB = table.Column<string>(type: "TEXT", nullable: true),
                    ComputerID = table.Column<int>(type: "INTEGER", nullable: false),
                    ComputersID = table.Column<long>(type: "INTEGER", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setting", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Setting_ComputerConfiguration_ComputersID",
                        column: x => x.ComputersID,
                        principalTable: "ComputerConfiguration",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "UserGroup",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleID = table.Column<long>(type: "INTEGER", nullable: false),
                    PermissionID = table.Column<long>(type: "INTEGER", nullable: false),
                    IsRead = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsInsert = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDelete = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsExecute = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGroup", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserGroup_Permission_PermissionID",
                        column: x => x.PermissionID,
                        principalTable: "Permission",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserGroup_Role_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Role",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Article",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Code = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Endlabel = table.Column<string>(type: "TEXT", nullable: true),
                    Version = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    SewingMachineParameterID = table.Column<long>(type: "INTEGER", nullable: true),
                    AutomatID = table.Column<long>(type: "INTEGER", nullable: false),
                    FabricLeather1ID = table.Column<long>(type: "INTEGER", nullable: true),
                    FabricLeather2ID = table.Column<long>(type: "INTEGER", nullable: true),
                    FabricLeather3ID = table.Column<long>(type: "INTEGER", nullable: true),
                    FabricLeather4ID = table.Column<long>(type: "INTEGER", nullable: true),
                    FabricLeather5ID = table.Column<long>(type: "INTEGER", nullable: true),
                    UpperThreadID = table.Column<long>(type: "INTEGER", nullable: true),
                    LowerThreadID = table.Column<long>(type: "INTEGER", nullable: true),
                    StitchLength = table.Column<string>(type: "TEXT", nullable: true),
                    Label = table.Column<string>(type: "TEXT", nullable: true),
                    LabelDefinition = table.Column<string>(type: "TEXT", nullable: true),
                    FreeSeamCountStart = table.Column<string>(type: "TEXT", nullable: true),
                    MaxStitchesFreeSeam = table.Column<string>(type: "TEXT", nullable: true),
                    SeamProfile = table.Column<string>(type: "TEXT", nullable: true),
                    MaxSpeedCritSection = table.Column<string>(type: "TEXT", nullable: true),
                    MaxSpeedNotCritSection = table.Column<string>(type: "TEXT", nullable: true),
                    Section1Reference = table.Column<string>(type: "TEXT", nullable: true),
                    Section1Min = table.Column<string>(type: "TEXT", nullable: true),
                    Section1Max = table.Column<string>(type: "TEXT", nullable: true),
                    Section1TolErrAllowed = table.Column<bool>(type: "INTEGER", nullable: false),
                    Section1StitchLength = table.Column<string>(type: "TEXT", nullable: true),
                    Section1StepForw = table.Column<string>(type: "TEXT", nullable: true),
                    Section1StepBackw = table.Column<string>(type: "TEXT", nullable: true),
                    Section1SL = table.Column<string>(type: "TEXT", nullable: true),
                    Section1Steps = table.Column<string>(type: "TEXT", nullable: true),
                    Section2Reference = table.Column<string>(type: "TEXT", nullable: true),
                    Section2Min = table.Column<string>(type: "TEXT", nullable: true),
                    Section2Max = table.Column<string>(type: "TEXT", nullable: true),
                    Section2TolErrAllowed = table.Column<bool>(type: "INTEGER", nullable: false),
                    Section2StitchLength = table.Column<string>(type: "TEXT", nullable: true),
                    Section2StepForw = table.Column<string>(type: "TEXT", nullable: true),
                    Section2StepBackw = table.Column<string>(type: "TEXT", nullable: true),
                    Section2SL = table.Column<string>(type: "TEXT", nullable: true),
                    Section2Steps = table.Column<string>(type: "TEXT", nullable: true),
                    Section3Reference = table.Column<string>(type: "TEXT", nullable: true),
                    Section3Min = table.Column<string>(type: "TEXT", nullable: true),
                    Section3Max = table.Column<string>(type: "TEXT", nullable: true),
                    Section3TolErrAllowed = table.Column<bool>(type: "INTEGER", nullable: false),
                    Section3StitchLength = table.Column<string>(type: "TEXT", nullable: true),
                    Section3StepForw = table.Column<string>(type: "TEXT", nullable: true),
                    Section3StepBackw = table.Column<string>(type: "TEXT", nullable: true),
                    Section3SL = table.Column<string>(type: "TEXT", nullable: true),
                    Section3Steps = table.Column<string>(type: "TEXT", nullable: true),
                    Section4Reference = table.Column<string>(type: "TEXT", nullable: true),
                    Section4Min = table.Column<string>(type: "TEXT", nullable: true),
                    Section4Max = table.Column<string>(type: "TEXT", nullable: true),
                    Section4TolErrAllowed = table.Column<bool>(type: "INTEGER", nullable: false),
                    Section4StitchLength = table.Column<string>(type: "TEXT", nullable: true),
                    Section4StepForw = table.Column<string>(type: "TEXT", nullable: true),
                    Section4StepBackw = table.Column<string>(type: "TEXT", nullable: true),
                    Section4SL = table.Column<string>(type: "TEXT", nullable: true),
                    Section4Steps = table.Column<string>(type: "TEXT", nullable: true),
                    Section5Reference = table.Column<string>(type: "TEXT", nullable: true),
                    Section5Min = table.Column<string>(type: "TEXT", nullable: true),
                    Section5Max = table.Column<string>(type: "TEXT", nullable: true),
                    Section5TolErrAllowed = table.Column<bool>(type: "INTEGER", nullable: false),
                    Section5StitchLength = table.Column<string>(type: "TEXT", nullable: true),
                    Section5StepForw = table.Column<string>(type: "TEXT", nullable: true),
                    Section5StepBackw = table.Column<string>(type: "TEXT", nullable: true),
                    Section5SL = table.Column<string>(type: "TEXT", nullable: true),
                    Section5Steps = table.Column<string>(type: "TEXT", nullable: true),
                    SeamStart = table.Column<string>(type: "TEXT", nullable: true),
                    SeamEnd = table.Column<string>(type: "TEXT", nullable: true),
                    EndlabelSeamMaxStiche = table.Column<string>(type: "TEXT", nullable: true),
                    EndlabelSeamSL = table.Column<string>(type: "TEXT", nullable: true),
                    EndlabelSeamSteps = table.Column<string>(type: "TEXT", nullable: true),
                    EndlabelStepsBack = table.Column<string>(type: "TEXT", nullable: true),
                    FabricLeather1Batch = table.Column<string>(type: "TEXT", nullable: true),
                    FabricLeather1MaterialCode = table.Column<string>(type: "TEXT", nullable: true),
                    FabricLeather1MaterialName = table.Column<string>(type: "TEXT", nullable: true),
                    FabricLeather2Batch = table.Column<string>(type: "TEXT", nullable: true),
                    FabricLeather2MaterialCode = table.Column<string>(type: "TEXT", nullable: true),
                    FabricLeather2MaterialName = table.Column<string>(type: "TEXT", nullable: true),
                    FabricLeather3Batch = table.Column<string>(type: "TEXT", nullable: true),
                    FabricLeather3MaterialCode = table.Column<string>(type: "TEXT", nullable: true),
                    FabricLeather3MaterialName = table.Column<string>(type: "TEXT", nullable: true),
                    FabricLeather4Batch = table.Column<string>(type: "TEXT", nullable: true),
                    FabricLeather4MaterialCode = table.Column<string>(type: "TEXT", nullable: true),
                    FabricLeather4MaterialName = table.Column<string>(type: "TEXT", nullable: true),
                    FabricLeather5Batch = table.Column<string>(type: "TEXT", nullable: true),
                    FabricLeather5MaterialCode = table.Column<string>(type: "TEXT", nullable: true),
                    FabricLeather5MaterialName = table.Column<string>(type: "TEXT", nullable: true),
                    UpperThreadMaterialCode = table.Column<string>(type: "TEXT", nullable: true),
                    UpperThreadInfo1 = table.Column<string>(type: "TEXT", nullable: true),
                    UpperThreadInfo2 = table.Column<string>(type: "TEXT", nullable: true),
                    UpperThreadMaterialName = table.Column<string>(type: "TEXT", nullable: true),
                    LowerThreadMaterialCode = table.Column<string>(type: "TEXT", nullable: true),
                    LowerThreadInfo1 = table.Column<string>(type: "TEXT", nullable: true),
                    LowerThreadInfo2 = table.Column<string>(type: "TEXT", nullable: true),
                    LowerThreadMaterialName = table.Column<string>(type: "TEXT", nullable: true),
                    ThreadTensionId = table.Column<string>(type: "TEXT", nullable: true),
                    ThreadTensionMonitoringType = table.Column<string>(type: "TEXT", nullable: true),
                    ThreadTensionSeam1Reference = table.Column<string>(type: "TEXT", nullable: true),
                    ThreadTensionSeam1Min = table.Column<string>(type: "TEXT", nullable: true),
                    ThreadTensionSeam1Max = table.Column<string>(type: "TEXT", nullable: true),
                    ThreadTensionSeam1StopFilter = table.Column<string>(type: "TEXT", nullable: true),
                    ThreadTensionSeam1StartMonitoring = table.Column<string>(type: "TEXT", nullable: true),
                    ThreadTensionSeam2Reference = table.Column<string>(type: "TEXT", nullable: true),
                    ThreadTensionSeam2Min = table.Column<string>(type: "TEXT", nullable: true),
                    ThreadTensionSeam2Max = table.Column<string>(type: "TEXT", nullable: true),
                    ThreadTensionSeam2StopFilter = table.Column<string>(type: "TEXT", nullable: true),
                    ThreadTensionSeam2StartMonitoring = table.Column<string>(type: "TEXT", nullable: true),
                    BacktackStartSeam1Forward = table.Column<string>(type: "TEXT", nullable: true),
                    BacktackStartSeam1Backward = table.Column<string>(type: "TEXT", nullable: true),
                    BacktackStartSeam1Repetition = table.Column<string>(type: "TEXT", nullable: true),
                    BacktackEndSeam1Forward = table.Column<string>(type: "TEXT", nullable: true),
                    BacktackEndSeam1Backward = table.Column<string>(type: "TEXT", nullable: true),
                    BacktackEndSeam1Repetition = table.Column<string>(type: "TEXT", nullable: true),
                    BacktackStartSeam2Forward = table.Column<string>(type: "TEXT", nullable: true),
                    BacktackStartSeam2Backward = table.Column<string>(type: "TEXT", nullable: true),
                    BacktackStartSeam2Repetition = table.Column<string>(type: "TEXT", nullable: true),
                    BacktackEndSeam2Forward = table.Column<string>(type: "TEXT", nullable: true),
                    BacktackEndSeam2Backward = table.Column<string>(type: "TEXT", nullable: true),
                    BacktackEndSeam2Repetition = table.Column<string>(type: "TEXT", nullable: true),
                    MiscellaneousInfo1 = table.Column<string>(type: "TEXT", nullable: true),
                    MiscellaneousInfo2 = table.Column<string>(type: "TEXT", nullable: true),
                    MiscellaneousInfo3 = table.Column<string>(type: "TEXT", nullable: true),
                    MiscellaneousInfo4 = table.Column<string>(type: "TEXT", nullable: true),
                    MiscellaneousInfo5 = table.Column<string>(type: "TEXT", nullable: true),
                    MiscellaneousInfo6 = table.Column<string>(type: "TEXT", nullable: true),
                    MiscellaneousInfo7 = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Article", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Article_Automat_AutomatID",
                        column: x => x.AutomatID,
                        principalTable: "Automat",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Article_SewingMachineParameter_SewingMachineParameterID",
                        column: x => x.SewingMachineParameterID,
                        principalTable: "SewingMachineParameter",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Article_AutomatID",
                table: "Article",
                column: "AutomatID");

            migrationBuilder.CreateIndex(
                name: "IX_Article_SewingMachineParameterID",
                table: "Article",
                column: "SewingMachineParameterID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Setting_ComputersID",
                table: "Setting",
                column: "ComputersID");

            migrationBuilder.CreateIndex(
                name: "IX_UserGroup_PermissionID",
                table: "UserGroup",
                column: "PermissionID");

            migrationBuilder.CreateIndex(
                name: "IX_UserGroup_RoleID",
                table: "UserGroup",
                column: "RoleID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppCodeGUIDefinition");

            migrationBuilder.DropTable(
                name: "AppDefinition");

            migrationBuilder.DropTable(
                name: "AppGroupGUIDefinition");

            migrationBuilder.DropTable(
                name: "Article");

            migrationBuilder.DropTable(
                name: "Bobbin");

            migrationBuilder.DropTable(
                name: "ChangeOfNeedlesRecords");

            migrationBuilder.DropTable(
                name: "ClipSenSorActivation");

            migrationBuilder.DropTable(
                name: "DBLog");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Part");

            migrationBuilder.DropTable(
                name: "Protocol");

            migrationBuilder.DropTable(
                name: "Report");

            migrationBuilder.DropTable(
                name: "Setting");

            migrationBuilder.DropTable(
                name: "SewingMachineConfiguration");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropTable(
                name: "SystemConfiguration");

            migrationBuilder.DropTable(
                name: "Thread");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "UserGroup");

            migrationBuilder.DropTable(
                name: "WindingParamter");

            migrationBuilder.DropTable(
                name: "Automat");

            migrationBuilder.DropTable(
                name: "SewingMachineParameter");

            migrationBuilder.DropTable(
                name: "ComputerConfiguration");

            migrationBuilder.DropTable(
                name: "Permission");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
