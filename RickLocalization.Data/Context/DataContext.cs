using Microsoft.EntityFrameworkCore;
using RickLocalization.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RickLocalization.Data.Context
{
    public class DataContext : DbContext
    {
        public DbSet<Rick> Ricks { get; set; }
        public DbSet<Dimension> Dimensions { get; set; }
        public DbSet<Morty> Morty { get; set; }
        public DbSet<Trip> Trip { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
