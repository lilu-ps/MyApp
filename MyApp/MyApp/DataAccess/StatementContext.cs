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

    }
}
