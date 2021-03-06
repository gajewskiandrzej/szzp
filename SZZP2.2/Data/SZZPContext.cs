﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SZZP2._2.Models;
using SZZP2._2.Models.SZZPViewModels;

namespace SZZP2._2.Data
{
    public class SZZPContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public SZZPContext(DbContextOptions<SZZPContext> options) : base(options)
        { }

        public DbSet<ADUser> ADUsers { get; set; }
        public DbSet<DataChange> DataChanges { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Dismissal> Dismissals { get; set; }
        public DbSet<Employment> Employments { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Status> Statuses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ADUser>().ToTable("ADUser");
            modelBuilder.Entity<DataChange>().ToTable("DataChange");
            modelBuilder.Entity<Department>().ToTable("Department");
            modelBuilder.Entity<Dismissal>().ToTable("Dismissal");
            modelBuilder.Entity<Employment>().ToTable("Employment");
            modelBuilder.Entity<Office>().ToTable("Office");
            modelBuilder.Entity<Position>().ToTable("Position");
            modelBuilder.Entity<Status>().ToTable("Status");
        }

    }
}
