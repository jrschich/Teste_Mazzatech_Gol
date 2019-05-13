using CoreAplicacao.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Data
{
    public class GolContext : DbContext
    {
        public GolContext(DbContextOptions<GolContext> options) : base(options)
        {
            
        }

        public DbSet<Airplane> Airplanes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Airplane>().ToTable("Airplane");
        }
    }
}
