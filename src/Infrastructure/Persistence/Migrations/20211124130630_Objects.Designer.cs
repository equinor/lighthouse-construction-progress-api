﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using lighthouse_construction_progress_api.Infrastructure.Persistence;

#nullable disable

namespace lighthouse_construction_progress_api.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211124130630_Objects")]
    partial class Objects
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("lighthouse_construction_progress_api.Domain.Entities.Activity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Acs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ActivityNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BasePlannedProgress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bef")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Besa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cancelled")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Csh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrentAf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrentAs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrentPlannedProgress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrentProgress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Du")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ef")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Es")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Esa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExpendedQuantity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("F10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobPackEstimatedQuantity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ls")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("NetId")
                        .HasColumnType("bigint");

                    b.Property<string>("OnTarget")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R10Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R10SubDiscipline")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R11Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R11Responsible")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R12Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R12ProjectMilestone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R13ActivityRole")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R13Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R14Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R14ProjectPhase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R15Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R15Fav")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R16Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R16Fas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R17Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R17Pau")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R18Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R18Module")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R19Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R19SapWbs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R1Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R1Wbs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R20Contract")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R20Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R21Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R21SubSystem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R22Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R22MaterialAllocationPhase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R23ContractorCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R23Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R24CostCenterDepartment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R24Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R25Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R25McPk")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R26Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R26TagTest")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R27Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R27SiteLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R28Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R28WorkType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R29Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R29JobDisc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R2Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R2MainCat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R30Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R30PersonalSortField")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R3Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R3Discipline")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R4Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R4MainArea")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R5Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R5SubArea")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R6Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R6System")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R7CommPk")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R7Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R8Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R8ProcurementPack")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R9Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R9Phase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rsh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Sequence")
                        .HasColumnType("bigint");

                    b.Property<string>("Tse")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("lighthouse_construction_progress_api.Domain.Entities.LciObject", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ActivityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ActivityNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cable_F_Area")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cable_F_Tag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cable_T_Area")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cable_T_Tag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComPkg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("EstimatedQuantity")
                        .HasColumnType("bigint");

                    b.Property<long?>("InstalledQuantity")
                        .HasColumnType("bigint");

                    b.Property<string>("McPkg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ObjectNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PipeTest")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("RemainingHours")
                        .HasColumnType("float");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StatusDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("StatusName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkOrderName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkOrderNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkTypeNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LciObjects");
                });

            modelBuilder.Entity("lighthouse_construction_progress_api.Domain.Entities.WorkOrder", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ActivityNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EstimatedEndTime")
                        .HasColumnType("datetime2");

                    b.Property<long>("EstimatedHours")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("EstimatedStartTime")
                        .HasColumnType("datetime2");

                    b.Property<double>("HoursUsed")
                        .HasColumnType("float");

                    b.Property<int>("Progress")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StatusDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("WoNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WorkOrders");
                });
#pragma warning restore 612, 618
        }
    }
}
