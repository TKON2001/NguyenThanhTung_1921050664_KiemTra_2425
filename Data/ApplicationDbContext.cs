using Microsoft.EntityFrameworkCore;
using NguyenThanhTung_1921050664_KiemTra.Models;

namespace NguyenThanhTung_1921050664_KiemTra.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public ApplicationDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=app.db");
            }
        }

        public DbSet<NguyenThanhTung_1921050664_KiemTra.Models.CA2> CA2s { get; set; }
    }
}