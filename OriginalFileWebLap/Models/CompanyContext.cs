using Microsoft.EntityFrameworkCore;
namespace OriginalFileWebLap.Models
{
    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options) { }
        public DbSet<MayTinh> mayTinhs { get; set; }
    }
}
