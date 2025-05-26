using Microsoft.EntityFrameworkCore;
using NguyenThanhTung_1921050664_KiemTra.Models;

namespace CA2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Parameterless constructor for design-time tools
        public ApplicationDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Only configure if not already configured (for design-time)
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=app.db");
            }
        }

        public DbSet<NguyenThanhTung_1921050664_KiemTra.Models.CA2> CA2s { get; set; }
    }
}