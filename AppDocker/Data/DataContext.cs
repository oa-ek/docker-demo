using Microsoft.EntityFrameworkCore;
using System;

namespace AppDocker.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<DemoData> Demos { get; set; }

        
    }

    public class DemoData
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}
