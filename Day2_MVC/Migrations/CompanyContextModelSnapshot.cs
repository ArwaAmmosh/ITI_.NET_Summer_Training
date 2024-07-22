﻿// <auto-generated />
using System;
using Day_MVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Day_MVC.Migrations
{
    [DbContext(typeof(CompanyContext))]
    partial class CompanyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Day_MVC.Models.Emp_Projects", b =>
                {
                    b.Property<int>("Emp_ID")
                        .HasColumnType("int");

                    b.Property<int>("Proj_ID")
                        .HasColumnType("int");

                    b.Property<int>("Working_Hours")
                        .HasColumnType("int");

                    b.HasKey("Emp_ID", "Proj_ID");

                    b.HasIndex("Proj_ID");

                    b.ToTable("EmployeeProjects");
                });

            modelBuilder.Entity("Day_MVC.Models.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("officeId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("officeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Day_MVC.Models.Office", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Offices");
                });

            modelBuilder.Entity("Day_MVC.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("officeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("officeId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("Day_MVC.Models.Emp_Projects", b =>
                {
                    b.HasOne("Day_MVC.Models.Employee", "Employee")
                        .WithMany("Emp_Projects")
                        .HasForeignKey("Emp_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Day_MVC.Models.Project", "Project")
                        .WithMany("EmpProjects")
                        .HasForeignKey("Proj_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Day_MVC.Models.Employee", b =>
                {
                    b.HasOne("Day_MVC.Models.Office", "office")
                        .WithMany("Employees")
                        .HasForeignKey("officeId");

                    b.Navigation("office");
                });

            modelBuilder.Entity("Day_MVC.Models.Project", b =>
                {
                    b.HasOne("Day_MVC.Models.Office", "office")
                        .WithMany("Projects")
                        .HasForeignKey("officeId");

                    b.Navigation("office");
                });

            modelBuilder.Entity("Day_MVC.Models.Employee", b =>
                {
                    b.Navigation("Emp_Projects");
                });

            modelBuilder.Entity("Day_MVC.Models.Office", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Projects");
                });

            modelBuilder.Entity("Day_MVC.Models.Project", b =>
                {
                    b.Navigation("EmpProjects");
                });
#pragma warning restore 612, 618
        }
    }
}