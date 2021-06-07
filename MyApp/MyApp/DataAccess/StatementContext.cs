using Microsoft.EntityFrameworkCore;
using MyApp.DataModels;
using System;

namespace MyApp.DataAccess
{
    public class StatementContext : DbContext
    {
        public StatementContext(DbContextOptions<StatementContext> options)
            : base(options)
        {
        }

        public DbSet<Statement> Statements { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Statement>(entity =>
            {
                entity.HasIndex(x => x.statementName);
            });
        }
    }
}