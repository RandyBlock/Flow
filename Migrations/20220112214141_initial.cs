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
                    SiteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteVisits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SiteVisits_Sites_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Sites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    SiteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkOrders_Sites_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Sites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "ClampOns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VerificationInstrumentName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    SiteVisitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClampOns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClampOns_SiteVisits_SiteVisitId",
                        column: x => x.SiteVisitId,
                        principalTable: "SiteVisits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dyes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    SiteVisitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dyes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dyes_SiteVisits_SiteVisitId",
                        column: x => x.SiteVisitId,
                        principalTable: "SiteVisits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Manuals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiteVisitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manuals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Manuals_SiteVisits_SiteVisitId",
                        column: x => x.SiteVisitId,
                        principalTable: "SiteVisits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClampOnConfirmationMeasurements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConfirmationValue = table.Column<double>(type: "float", nullable: true),
                    MeterValue = table.Column<double>(type: "float", nullable: true),
                    RepositoryValue = table.Column<double>(type: "float", nullable: true),
                    MeasurementType = table.Column<int>(type: "int", nullable: true),
                    UnitType = table.Column<int>(type: "int", nullable: true),
                    ClampOnId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClampOnConfirmationMeasurements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClampOnConfirmationMeasurements_ClampOns_ClampOnId",
                        column: x => x.ClampOnId,
                        principalTable: "ClampOns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BathMeasurements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PPB = table.Column<double>(type: "float", nullable: true),
                    MVolt = table.Column<double>(type: "float", nullable: true),
                    Temperature = table.Column<double>(type: "float", nullable: true),
                    BathType = table.Column<int>(type: "int", nullable: true),
                    DyeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BathMeasurements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BathMeasurements_Dyes_DyeId",
                        column: x => x.DyeId,
                        principalTable: "Dyes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Calibrations",
                columns: table => new
                {
                    DyeId = table.Column<int>(type: "int", nullable: false),
                    DateCalibrated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Intercept = table.Column<double>(type: "float", nullable: true),
                    Slope = table.Column<double>(type: "float", nullable: true),
                    TargetppB = table.Column<double>(type: "float", nullable: true),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calibrations", x => x.DyeId);
                    table.ForeignKey(
                        name: "FK_Calibrations_Dyes_DyeId",
                        column: x => x.DyeId,
                        principalTable: "Dyes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DyeConfirmationMeasurements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConfirmationValue = table.Column<double>(type: "float", nullable: true),
                    MeterValue = table.Column<double>(type: "float", nullable: true),
                    RepositoryValue = table.Column<double>(type: "float", nullable: true),
                    MeasurementType = table.Column<int>(type: "int", nullable: true),
                    UnitType = table.Column<int>(type: "int", nullable: true),
                    DyeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DyeConfirmationMeasurements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DyeConfirmationMeasurements_Dyes_DyeId",
                        column: x => x.DyeId,
                        principalTable: "Dyes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ManualConfirmationMeasurements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConfirmationValue = table.Column<double>(type: "float", nullable: true),
                    MeterValue = table.Column<double>(type: "float", nullable: true),
                    RepositoryValue = table.Column<double>(type: "float", nullable: true),
                    MeasurementType = table.Column<int>(type: "int", nullable: true),
                    UnitType = table.Column<int>(type: "int", nullable: true),
                    ManualId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManualConfirmationMeasurements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ManualConfirmationMeasurements_Manuals_ManualId",
                        column: x => x.ManualId,
                        principalTable: "Manuals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BathMeasurements_DyeId",
                table: "BathMeasurements",
                column: "DyeId");

            migrationBuilder.CreateIndex(
                name: "IX_ClampOnConfirmationMeasurements_ClampOnId",
                table: "ClampOnConfirmationMeasurements",
                column: "ClampOnId");

            migrationBuilder.CreateIndex(
                name: "IX_ClampOns_SiteVisitId",
                table: "ClampOns",
                column: "SiteVisitId");

            migrationBuilder.CreateIndex(
                name: "IX_DyeConfirmationMeasurements_DyeId",
                table: "DyeConfirmationMeasurements",
                column: "DyeId");

            migrationBuilder.CreateIndex(
                name: "IX_Dyes_SiteVisitId",
                table: "Dyes",
                column: "SiteVisitId");

            migrationBuilder.CreateIndex(
                name: "IX_ManualConfirmationMeasurements_ManualId",
                table: "ManualConfirmationMeasurements",
                column: "ManualId");

            migrationBuilder.CreateIndex(
                name: "IX_Manuals_SiteVisitId",
                table: "Manuals",
                column: "SiteVisitId");

            migrationBuilder.CreateIndex(
                name: "IX_SiteVisits_SiteId",
                table: "SiteVisits",
                column: "SiteId");

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
                name: "BathMeasurements");

            migrationBuilder.DropTable(
                name: "Calibrations");

            migrationBuilder.DropTable(
                name: "CheckLists");

            migrationBuilder.DropTable(
                name: "ClampOnConfirmationMeasurements");

            migrationBuilder.DropTable(
                name: "DyeConfirmationMeasurements");

            migrationBuilder.DropTable(
                name: "ManualConfirmationMeasurements");

            migrationBuilder.DropTable(
                name: "WorkOrders");

            migrationBuilder.DropTable(
                name: "ClampOns");

            migrationBuilder.DropTable(
                name: "Dyes");

            migrationBuilder.DropTable(
                name: "Manuals");

            migrationBuilder.DropTable(
                name: "SiteVisits");

            migrationBuilder.DropTable(
                name: "Sites");
        }
    }
}
