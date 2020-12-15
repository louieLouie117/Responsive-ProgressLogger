using Microsoft.EntityFrameworkCore;

namespace ProgressLog.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }


        public DbSet<User> Users { get; set; }

        public DbSet<LogRecord> LogRecords { get; set; }

        public DbSet<Section> Sections { get; set; }

    }
}