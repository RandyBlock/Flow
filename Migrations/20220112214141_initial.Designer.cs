﻿// <auto-generated />
using System;
using Flow;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Flow.Migrations
{
    [DbContext(typeof(FlowDBContext))]
    [Migration("20220112214141_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Flow.WPF.Models.BathMeasurement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("BathType")
                        .HasColumnType("int");

                    b.Property<int>("DyeId")
                        .HasColumnType("int");

                    b.Property<double?>("MVolt")
                        .HasColumnType("float");

                    b.Property<double?>("PPB")
                        .HasColumnType("float");

                    b.Property<double?>("Temperature")
                        .HasColumnType("float");

                    b.Property<DateTime?>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DyeId");

                    b.ToTable("BathMeasurements");
                });

            modelBuilder.Entity("Flow.WPF.Models.ClampOn", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("SiteVisitId")
                        .HasColumnType("int");

                    b.Property<string>("VerificationInstrumentName")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.HasIndex("SiteVisitId");

                    b.ToTable("ClampOns");
                });

            modelBuilder.Entity("Flow.WPF.Models.ClampOnConfirmationMeasurement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ClampOnId")
                        .HasColumnType("int");

                    b.Property<double?>("ConfirmationValue")
                        .HasColumnType("float");

                    b.Property<int?>("MeasurementType")
                        .HasColumnType("int");

                    b.Property<double?>("MeterValue")
                        .HasColumnType("float");

                    b.Property<double?>("RepositoryValue")
                        .HasColumnType("float");

                    b.Property<DateTime?>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UnitType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClampOnId");

                    b.ToTable("ClampOnConfirmationMeasurements");
                });

            modelBuilder.Entity("Flow.WPF.Models.Dye", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double?>("CalculateInjectionRate")
                        .HasColumnType("float");

                    b.Property<double?>("ClearDyePPB")
                        .HasColumnType("float");

                    b.Property<double?>("ClearIntercept")
                        .HasColumnType("float");

                    b.Property<DateTime?>("DyeEnded")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DyeStarted")
                        .HasColumnType("datetime2");

                    b.Property<double?>("ManualInjectionRate")
                        .HasColumnType("float");

                    b.Property<double?>("RecoveryRatio")
                        .HasColumnType("float");

                    b.Property<double?>("SewerDyePPB")
                        .HasColumnType("float");

                    b.Property<double?>("SewerIntercept")
                        .HasColumnType("float");

                    b.Property<int>("SiteVisitId")
                        .HasColumnType("int");

                    b.Property<string>("VerificationInstrumentName")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<double?>("WeightAfter")
                        .HasColumnType("float");

                    b.Property<double?>("WeightBefore")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("SiteVisitId");

                    b.ToTable("Dyes");
                });

            modelBuilder.Entity("Flow.WPF.Models.DyeConfirmationMeasurement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double?>("ConfirmationValue")
                        .HasColumnType("float");

                    b.Property<int>("DyeId")
                        .HasColumnType("int");

                    b.Property<int?>("MeasurementType")
                        .HasColumnType("int");

                    b.Property<double?>("MeterValue")
                        .HasColumnType("float");

                    b.Property<double?>("RepositoryValue")
                        .HasColumnType("float");

                    b.Property<DateTime?>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UnitType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DyeId");

                    b.ToTable("DyeConfirmationMeasurements");
                });

            modelBuilder.Entity("Flow.WPF.Models.Manual", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("SiteVisitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SiteVisitId");

                    b.ToTable("Manuals");
                });

            modelBuilder.Entity("Flow.WPF.Models.ManualConfirmationMeasurement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double?>("ConfirmationValue")
                        .HasColumnType("float");

                    b.Property<int>("ManualId")
                        .HasColumnType("int");

                    b.Property<int?>("MeasurementType")
                        .HasColumnType("int");

                    b.Property<double?>("MeterValue")
                        .HasColumnType("float");

                    b.Property<double?>("RepositoryValue")
                        .HasColumnType("float");

                    b.Property<DateTime?>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UnitType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ManualId");

                    b.ToTable("ManualConfirmationMeasurements");
                });

            modelBuilder.Entity("Flow.WPF.Models.Site", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Acronym")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("Area")
                        .HasColumnType("int");

                    b.Property<string>("Chainage")
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("Drawing")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("MHNumber")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("TMP")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Sites");
                });

            modelBuilder.Entity("Flow.WPF.Models.SiteVisit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateTimeVisit")
                        .HasColumnType("datetime2");

                    b.Property<int>("SiteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SiteId");

                    b.ToTable("SiteVisits");
                });

            modelBuilder.Entity("Flow.WPF.Models.WorkOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool?>("Completed")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SiteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SiteId");

                    b.ToTable("WorkOrders");
                });

            modelBuilder.Entity("Flow.WPF.Models.BathMeasurement", b =>
                {
                    b.HasOne("Flow.WPF.Models.Dye", "Dye")
                        .WithMany("BathMeasurements")
                        .HasForeignKey("DyeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dye");
                });

            modelBuilder.Entity("Flow.WPF.Models.ClampOn", b =>
                {
                    b.HasOne("Flow.WPF.Models.SiteVisit", "SiteVisit")
                        .WithMany("ClampOn")
                        .HasForeignKey("SiteVisitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SiteVisit");
                });

            modelBuilder.Entity("Flow.WPF.Models.ClampOnConfirmationMeasurement", b =>
                {
                    b.HasOne("Flow.WPF.Models.ClampOn", "ClampOn")
                        .WithMany("Measurements")
                        .HasForeignKey("ClampOnId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClampOn");
                });

            modelBuilder.Entity("Flow.WPF.Models.Dye", b =>
                {
                    b.HasOne("Flow.WPF.Models.SiteVisit", "SiteVisit")
                        .WithMany("Dye")
                        .HasForeignKey("SiteVisitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("Flow.WPF.Models.Calibration", "CalibrationUsed", b1 =>
                        {
                            b1.Property<int>("DyeId")
                                .HasColumnType("int");

                            b1.Property<DateTime?>("DateCalibrated")
                                .HasColumnType("datetime2");

                            b1.Property<int>("Id")
                                .HasColumnType("int");

                            b1.Property<double?>("Intercept")
                                .HasColumnType("float");

                            b1.Property<double?>("Slope")
                                .HasColumnType("float");

                            b1.Property<double?>("TargetppB")
                                .HasColumnType("float");

                            b1.HasKey("DyeId");

                            b1.ToTable("Calibrations");

                            b1.WithOwner("Dye")
                                .HasForeignKey("DyeId");

                            b1.Navigation("Dye");
                        });

                    b.Navigation("CalibrationUsed");

                    b.Navigation("SiteVisit");
                });

            modelBuilder.Entity("Flow.WPF.Models.DyeConfirmationMeasurement", b =>
                {
                    b.HasOne("Flow.WPF.Models.Dye", "Dye")
                        .WithMany("DyeMeasurements")
                        .HasForeignKey("DyeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dye");
                });

            modelBuilder.Entity("Flow.WPF.Models.Manual", b =>
                {
                    b.HasOne("Flow.WPF.Models.SiteVisit", "SiteVisit")
                        .WithMany("Manual")
                        .HasForeignKey("SiteVisitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SiteVisit");
                });

            modelBuilder.Entity("Flow.WPF.Models.ManualConfirmationMeasurement", b =>
                {
                    b.HasOne("Flow.WPF.Models.Manual", "Manual")
                        .WithMany("Measurements")
                        .HasForeignKey("ManualId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manual");
                });

            modelBuilder.Entity("Flow.WPF.Models.Site", b =>
                {
                    b.OwnsOne("Flow.WPF.Models.Address", "Address", b1 =>
                        {
                            b1.Property<int>("SiteId")
                                .HasColumnType("int");

                            b1.Property<string>("City")
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.Property<string>("GPSLocation")
                                .HasMaxLength(60)
                                .HasColumnType("nvarchar(60)");

                            b1.Property<int>("Id")
                                .HasColumnType("int");

                            b1.Property<string>("Street")
                                .HasMaxLength(60)
                                .HasColumnType("nvarchar(60)");

                            b1.Property<string>("StreetNumber")
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)");

                            b1.HasKey("SiteId");

                            b1.ToTable("Adresses");

                            b1.WithOwner("Site")
                                .HasForeignKey("SiteId");

                            b1.Navigation("Site");
                        });

                    b.Navigation("Address");
                });

            modelBuilder.Entity("Flow.WPF.Models.SiteVisit", b =>
                {
                    b.HasOne("Flow.WPF.Models.Site", "Site")
                        .WithMany("SiteVisit")
                        .HasForeignKey("SiteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("Flow.WPF.Models.CheckList", "CheckList", b1 =>
                        {
                            b1.Property<int>("SiteVisitId")
                                .HasColumnType("int");

                            b1.Property<bool?>("BatteryChanged")
                                .HasColumnType("bit");

                            b1.Property<bool?>("Calibrated")
                                .HasColumnType("bit");

                            b1.Property<bool?>("EquipmentInstalled")
                                .HasColumnType("bit");

                            b1.Property<bool?>("EquipmentRemoved")
                                .HasColumnType("bit");

                            b1.Property<bool?>("EquipmentRepaired")
                                .HasColumnType("bit");

                            b1.Property<int>("Id")
                                .HasColumnType("int");

                            b1.Property<bool?>("Inspected")
                                .HasColumnType("bit");

                            b1.Property<bool?>("SensorCleaned")
                                .HasColumnType("bit");

                            b1.Property<bool?>("Verified")
                                .HasColumnType("bit");

                            b1.HasKey("SiteVisitId");

                            b1.ToTable("CheckLists");

                            b1.WithOwner("SiteVisit")
                                .HasForeignKey("SiteVisitId");

                            b1.Navigation("SiteVisit");
                        });

                    b.Navigation("CheckList");

                    b.Navigation("Site");
                });

            modelBuilder.Entity("Flow.WPF.Models.WorkOrder", b =>
                {
                    b.HasOne("Flow.WPF.Models.Site", "Site")
                        .WithMany("WorkOrder")
                        .HasForeignKey("SiteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Site");
                });

            modelBuilder.Entity("Flow.WPF.Models.ClampOn", b =>
                {
                    b.Navigation("Measurements");
                });

            modelBuilder.Entity("Flow.WPF.Models.Dye", b =>
                {
                    b.Navigation("BathMeasurements");

                    b.Navigation("DyeMeasurements");
                });

            modelBuilder.Entity("Flow.WPF.Models.Manual", b =>
                {
                    b.Navigation("Measurements");
                });

            modelBuilder.Entity("Flow.WPF.Models.Site", b =>
                {
                    b.Navigation("SiteVisit");

                    b.Navigation("WorkOrder");
                });

            modelBuilder.Entity("Flow.WPF.Models.SiteVisit", b =>
                {
                    b.Navigation("ClampOn");

                    b.Navigation("Dye");

                    b.Navigation("Manual");
                });
#pragma warning restore 612, 618
        }
    }
}
