﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using employeeManagmentSoftware.Data;

#nullable disable

namespace employeeManagmentSoftware.Migrations
{
    [DbContext(typeof(employeeManagmentSoftwareContext))]
    partial class employeeManagmentSoftwareContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("employeeManagmentSoftware.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("EmployeeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.Property<int>("Tenure")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employee");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EmployeeId = 1,
                            EmployeeName = "John Gomez",
                            Salary = 250000.0,
                            Tenure = 5,
                            Title = "Chief Executive Officer"
                        },
                        new
                        {
                            Id = 2,
                            EmployeeId = 2,
                            EmployeeName = "Genesis Rea",
                            Salary = 250000.0,
                            Tenure = 5,
                            Title = "Chief Operating Officer"
                        },
                        new
                        {
                            Id = 3,
                            EmployeeId = 3,
                            EmployeeName = "Jane Doe",
                            Salary = 150000.0,
                            Tenure = 3,
                            Title = "Senior Software Engineer"
                        },
                        new
                        {
                            Id = 4,
                            EmployeeId = 4,
                            EmployeeName = "John Doe",
                            Salary = 70000.0,
                            Tenure = 1,
                            Title = "Engineering I"
                        },
                        new
                        {
                            Id = 5,
                            EmployeeId = 5,
                            EmployeeName = "Ash Williams",
                            Salary = 85000.0,
                            Tenure = 3,
                            Title = "Marketing Specialist"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
