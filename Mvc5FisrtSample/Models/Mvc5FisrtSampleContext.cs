using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mvc5FisrtSample.Models
{
    public class Mvc5FisrtSampleContext : DbContext
    {
        public Mvc5FisrtSampleContext() : base("name=Mvc5FisrtSampleContext")
        {
        }

        public DbSet<Child> Children { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Sex> Sexes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Parent>()
                .HasRequired(c => c.Sex)
                .WithMany()
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Child>()
                .HasRequired(c => c.Sex)
                .WithMany()
                .WillCascadeOnDelete(false);
        }
    }
}
