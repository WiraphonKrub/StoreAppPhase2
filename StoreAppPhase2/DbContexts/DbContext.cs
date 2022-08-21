using System;
using Microsoft.EntityFrameworkCore;
using StoreAppPhase2.Entities;
using StoreAppPhase2.EntityModels;

namespace StoreAppPhase2.DbContexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
              : base(options)
        {
        }

        public DbSet<EmployeesData> EmployeesDatas { get; set; }
        public DbSet<SaleInvoices> SaleInvoices { get; set; }
        public DbSet<BookingServices> bookingServices { get; set; }



        //Status Table
        public DbSet<StatusItems> StatusItems { get; set; }
        public DbSet<StatusForSale> statusForSales { get; set; }



        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //}
    }
}