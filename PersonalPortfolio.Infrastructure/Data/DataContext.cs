using Microsoft.EntityFrameworkCore;
using PersonalPortfolio.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalPortfolio.Infrastructure.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {

        }

        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Owner> Owner { get; set; }
    }
}
