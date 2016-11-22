using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EvalAppCoreAut.Models;

namespace EvalAppCoreAut.Models
{
    public class CFTDbContext : DbContext
    {
        public CFTDbContext(DbContextOptions<CFTDbContext> options) : base(options)
        { }

        public DbSet<Employee> Employees { get; set; }
        //public DbSet<ServiceClass> Services { get; set; }
        public DbSet<Contracts> Contracts { get; set; }
        public DbSet<Clients> Clients { get; set; }
        public DbSet<TimeEntry> TimeEntries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=Test\test;Database=EvalAppCoreDB;Trusted_Connection=True;");
        }

    }





}
