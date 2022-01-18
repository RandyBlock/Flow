using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Flow.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Acronym = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Area = table.Column<int>(type: "int", nullable: true),
                    MHNumber = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    Chainage = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    Drawing = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TMP = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Adresses",
                columns: table => new
                {
                    SiteId = table.Column<int>(type: "int", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    StreetNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GPSLocation = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresses", x => x.SiteId);
                    table.ForeignKey(
                        name: "FK_Adresses_Sites_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Sites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SiteVisits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTimeVisit = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteVisits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SiteVisits_Sites_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Sites",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WorkOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Completed = table.Column<bool>(type: "bit", nullable: true),
                    SiteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkOrders_Sites_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Sites",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CheckLists",
                columns: table => new
                {
                    SiteVisitId = table.Column<int>(type: "int", nullable: false),
                    BatteryChanged = table.Column<bool>(type: "bit", nullable: true),
                    SensorCleaned = table.Column<bool>(type: "bit", nullable: true),
                    Calibrated = table.Column<bool>(type: "bit", nullable: true),
                    Verified = table.Column<bool>(type: "bit", nullable: true),
                    EquipmentInstalled = table.Column<bool>(type: "bit", nullable: true),
                    EquipmentRemoved = table.Column<bool>(type: "bit", nullable: true),
                    EquipmentRepaired = table.Column<bool>(type: "bit", nullable: true),
                    Inspected = table.Column<bool>(type: "bit", nullable: true),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckLists", x => x.SiteVisitId);
                    table.ForeignKey(
                        name: "FK_CheckLists_SiteVisits_SiteVisitId",
                        column: x => x.SiteVisitId,
                        principalTable: "SiteVisits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Verifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SampleRateSeconds = table.Column<int>(type: "int", nullable: false),
                    SiteVisitId = table.Column<int>(type: "int", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MeterType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SensorType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClearDyePPB = table.Column<double>(type: "float", nullable: true),
                    SewerDyePPB = table.Column<double>(type: "float", nullable: true),
                    ClearIntercept = table.Column<double>(type: "float", nullable: true),
                    SewerIntercept = table.Column<double>(type: "float", nullable: true),
                    RecoveryRatio = table.Column<double>(type: "float", nullable: true),
                    DyeStarted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DyeEnded = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ManualInjectionRate = table.Column<double>(type: "float", nullable: true),
                    WeightAfter = table.Column<double>(type: "float", nullable: true),
                    WeightBefore = table.Column<double>(type: "float", nullable: true),
                    CalculateInjectionRate = table.Column<double>(type: "float", nullable: true),
                    VerificationInstrumentName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    EntryRequired = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Verifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Verifications_SiteVisits_SiteVisitId",
                        column: x => x.SiteVisitId,
                        principalTable: "SiteVisits",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Calibrations",
                columns: table => new
                {
                    DyeVerificationId = table.Column<int>(type: "int", nullable: false),
                    DateCalibrated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Intercept = table.Column<double>(type: "float", nullable: true),
                    Slope = table.Column<double>(type: "float", nullable: true),
                    TargetppB = table.Column<double>(type: "float", nullable: true),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calibrations", x => x.DyeVerificationId);
                    table.ForeignKey(
                        name: "FK_Calibrations_Verifications_DyeVerificationId",
                        column: x => x.DyeVerificationId,
                        principalTable: "Verifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VerificationMeasurements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MValue = table.Column<double>(type: "float", nullable: false),
                    MType = table.Column<int>(type: "int", nullable: false),
                    UType = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VerificationId = table.Column<int>(type: "int", nullable: true),
                    BathType = table.Column<int>(type: "int", nullable: true),
                    BathMeasurement_DyeVerificationId = table.Column<int>(type: "int", nullable: true),
                    MeterName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClampOnMeasurement_TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DyeMeasurement_TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlowRate = table.Column<double>(type: "float", nullable: true),
                    DyeMeasurement_UnitType = table.Column<int>(type: "int", nullable: true),
                    DyeVerificationId = table.Column<int>(type: "int", nullable: true),
                    MeterValue = table.Column<double>(type: "float", nullable: true),
                    UnitType = table.Column<int>(type: "int", nullable: true),
                    MeasurementType = table.Column<int>(type: "int", nullable: true),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VerificationMeasurements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VerificationMeasurements_Verifications_BathMeasurement_DyeVerificationId",
                        column: x => x.BathMeasurement_DyeVerificationId,
                        principalTable: "Verifications",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VerificationMeasurements_Verifications_DyeVerificationId",
                        column: x => x.DyeVerificationId,
                        principalTable: "Verifications",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VerificationMeasurements_Verifications_VerificationId",
                        column: x => x.VerificationId,
                        principalTable: "Verifications",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SiteVisits_SiteId",
                table: "SiteVisits",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_VerificationMeasurements_BathMeasurement_DyeVerificationId",
                table: "VerificationMeasurements",
                column: "BathMeasurement_DyeVerificationId");

            migrationBuilder.CreateIndex(
                name: "IX_VerificationMeasurements_DyeVerificationId",
                table: "VerificationMeasurements",
                column: "DyeVerificationId");

            migrationBuilder.CreateIndex(
                name: "IX_VerificationMeasurements_VerificationId",
                table: "VerificationMeasurements",
                column: "VerificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Verifications_SiteVisitId",
                table: "Verifications",
                column: "SiteVisitId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkOrders_SiteId",
                table: "WorkOrders",
                column: "SiteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adresses");

            migrationBuilder.DropTable(
                name: "Calibrations");

            migrationBuilder.DropTable(
                name: "CheckLists");

            migrationBuilder.DropTable(
                name: "VerificationMeasurements");

            migrationBuilder.DropTable(
                name: "WorkOrders");

            migrationBuilder.DropTable(
                name: "Verifications");

            migrationBuilder.DropTable(
                name: "SiteVisits");

            migrationBuilder.DropTable(
                name: "Sites");
        }
    }
}
