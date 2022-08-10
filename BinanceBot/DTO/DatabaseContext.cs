using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BinanceBot.Models;
using System.Runtime.ConstrainedExecution;
using System.Xml;

namespace BinanceBot
{
    public class DatabaseContext : DbContext
    {
      
        readonly string connectionString = @$"Data Source=database.db";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite(connectionString);

        public DbSet<Coin> Mumlar { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			modelBuilder.Entity<Mum>(b =>
			{
				b.HasKey(e => e.Count);
                b.Property(e => e.Count).UseIdentityColumn();
			});

		}
    }
}
