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

        public DbSet<Employees> Employees { get; set; }
        public DbSet<SellingEM> SellingEM { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //}
    }
}

