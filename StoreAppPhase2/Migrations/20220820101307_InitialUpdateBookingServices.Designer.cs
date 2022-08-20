﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StoreAppPhase2.DbContexts;

#nullable disable

namespace StoreAppPhase2.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220820101307_InitialUpdateBookingServices")]
    partial class InitialUpdateBookingServices
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("StoreAppPhase2.Entities.StatusItems", b =>
                {
                    b.Property<int>("StatusItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StatusItemID"), 1L, 1);

                    b.Property<string>("StatusItemName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("StatusItemID");

                    b.ToTable("StatusItems");
                });

            modelBuilder.Entity("StoreAppPhase2.EntityModels.BookingServices", b =>
                {
                    b.Property<int>("BookingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingID"), 1L, 1);

                    b.Property<string>("BookingName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DueDate")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("StatusItemID")
                        .HasColumnType("int");

                    b.HasKey("BookingID");

                    b.HasIndex("StatusItemID");

                    b.ToTable("BookingServices");
                });

            modelBuilder.Entity("StoreAppPhase2.EntityModels.EmployeesData", b =>
                {
                    b.Property<int>("IdEm")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEm"), 1L, 1);

                    b.Property<string>("AddressEm")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstNameEm")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastNameEm")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("RangeWorkingEm")
                        .HasMaxLength(15)
                        .HasColumnType("int");

                    b.Property<decimal>("SalaryEm")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdEm");

                    b.ToTable("EmployeesDatas");
                });

            modelBuilder.Entity("StoreAppPhase2.EntityModels.SaleInvoices", b =>
                {
                    b.Property<int>("SaleInvoiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SaleInvoiceID"), 1L, 1);

                    b.Property<int>("IdEM")
                        .HasColumnType("int");

                    b.Property<int>("InvoiceNo")
                        .HasColumnType("int");

                    b.Property<int>("StatusItemID")
                        .HasColumnType("int");

                    b.HasKey("SaleInvoiceID");

                    b.HasIndex("IdEM");

                    b.HasIndex("StatusItemID");

                    b.ToTable("SaleInvoices");
                });

            modelBuilder.Entity("StoreAppPhase2.EntityModels.BookingServices", b =>
                {
                    b.HasOne("StoreAppPhase2.Entities.StatusItems", "statusItems")
                        .WithMany("BookingServices")
                        .HasForeignKey("StatusItemID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("statusItems");
                });

            modelBuilder.Entity("StoreAppPhase2.EntityModels.SaleInvoices", b =>
                {
                    b.HasOne("StoreAppPhase2.EntityModels.EmployeesData", "employeesData")
                        .WithMany("saleInvoices")
                        .HasForeignKey("IdEM")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StoreAppPhase2.Entities.StatusItems", "statusItems")
                        .WithMany("saleInvoices")
                        .HasForeignKey("StatusItemID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("employeesData");

                    b.Navigation("statusItems");
                });

            modelBuilder.Entity("StoreAppPhase2.Entities.StatusItems", b =>
                {
                    b.Navigation("BookingServices");

                    b.Navigation("saleInvoices");
                });

            modelBuilder.Entity("StoreAppPhase2.EntityModels.EmployeesData", b =>
                {
                    b.Navigation("saleInvoices");
                });
#pragma warning restore 612, 618
        }
    }
}