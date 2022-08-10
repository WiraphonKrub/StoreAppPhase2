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
        public DbSet<SaleInvoice> SaleInvoices { get; set; }
        public DbSet<StatusItem> StatusItems { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //}
    }
}

