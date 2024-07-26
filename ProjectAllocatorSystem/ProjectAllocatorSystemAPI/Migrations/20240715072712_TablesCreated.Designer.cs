﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectAllocatorSystemAPI.Data;

#nullable disable

namespace ProjectAllocatorSystemAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240715072712_TablesCreated")]
    partial class TablesCreated
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EmployeeSkill", b =>
                {
                    b.Property<int>("EmployeesEmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("SkillsSkillId")
                        .HasColumnType("int");

                    b.HasKey("EmployeesEmployeeId", "SkillsSkillId");

                    b.HasIndex("SkillsSkillId");

                    b.ToTable("EmployeeSkill");
                });

            modelBuilder.Entity("ProjectAllocatorSystemAPI.Models.Allocation", b =>
                {
                    b.Property<int>("AllocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AllocationId"), 1L, 1);

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("InternalProjectId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TrainingId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("AllocationId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("InternalProjectId");

                    b.HasIndex("TrainingId");

                    b.HasIndex("TypeId");

                    b.ToTable("Allocations");
                });

            modelBuilder.Entity("ProjectAllocatorSystemAPI.Models.AllocationType", b =>
                {
                    b.Property<int>("TypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TypeId"), 1L, 1);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TypeId");

                    b.ToTable("AllocationTypes");
                });

            modelBuilder.Entity("ProjectAllocatorSystemAPI.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"), 1L, 1);

                    b.Property<DateTime?>("BenchEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("BenchStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("JobRoleId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId");

                    b.HasIndex("JobRoleId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("ProjectAllocatorSystemAPI.Models.InternalProject", b =>
                {
                    b.Property<int>("InternalProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InternalProjectId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InternalProjectId");

                    b.ToTable("InternalProjects");
                });

            modelBuilder.Entity("ProjectAllocatorSystemAPI.Models.JobRole", b =>
                {
                    b.Property<int>("JobRoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JobRoleId"), 1L, 1);

                    b.Property<string>("JobRoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JobRoleId");

                    b.ToTable("JobRoles");
                });

            modelBuilder.Entity("ProjectAllocatorSystemAPI.Models.Skill", b =>
                {
                    b.Property<int>("SkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SkillId"), 1L, 1);

                    b.Property<int>("SkillName")
                        .HasColumnType("int");

                    b.HasKey("SkillId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("ProjectAllocatorSystemAPI.Models.Training", b =>
                {
                    b.Property<int>("TrainingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TrainingId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TrainingId");

                    b.ToTable("Trainings");
                });

            modelBuilder.Entity("EmployeeSkill", b =>
                {
                    b.HasOne("ProjectAllocatorSystemAPI.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectAllocatorSystemAPI.Models.Skill", null)
                        .WithMany()
                        .HasForeignKey("SkillsSkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProjectAllocatorSystemAPI.Models.Allocation", b =>
                {
                    b.HasOne("ProjectAllocatorSystemAPI.Models.Employee", "Employee")
                        .WithMany("Allocations")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectAllocatorSystemAPI.Models.InternalProject", "InternalProject")
                        .WithMany()
                        .HasForeignKey("InternalProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectAllocatorSystemAPI.Models.Training", "Training")
                        .WithMany()
                        .HasForeignKey("TrainingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectAllocatorSystemAPI.Models.AllocationType", "AllocationType")
                        .WithMany("Allocations")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AllocationType");

                    b.Navigation("Employee");

                    b.Navigation("InternalProject");

                    b.Navigation("Training");
                });

            modelBuilder.Entity("ProjectAllocatorSystemAPI.Models.Employee", b =>
                {
                    b.HasOne("ProjectAllocatorSystemAPI.Models.JobRole", "JobRole")
                        .WithMany("Employees")
                        .HasForeignKey("JobRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("JobRole");
                });

            modelBuilder.Entity("ProjectAllocatorSystemAPI.Models.AllocationType", b =>
                {
                    b.Navigation("Allocations");
                });

            modelBuilder.Entity("ProjectAllocatorSystemAPI.Models.Employee", b =>
                {
                    b.Navigation("Allocations");
                });

            modelBuilder.Entity("ProjectAllocatorSystemAPI.Models.JobRole", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
