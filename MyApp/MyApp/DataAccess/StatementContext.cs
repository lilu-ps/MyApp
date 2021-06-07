using Microsoft.EntityFrameworkCore;
using MyApp.Models;
using System;

namespace MyApp.DataAccess
{
    public class StatementContext : DbContext
    {
        public StatementContext(DbContextOptions<StatementContext> options)
            : base(options)
        {
        }

        public DbSet<StatementModel> Statements { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StatementModel>(entity =>
            {
                entity.HasIndex(x => x.statementName);
            });
        }
    }
}