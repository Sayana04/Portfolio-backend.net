using Microsoft.EntityFrameworkCore;

namespace PortfolioApi.Models;
public class AboutMeContext : DbContext
{
    public AboutMeContext(DbContextOptions<AboutMeContext> options)
        : base(options)
    {
    }

    public DbSet<AboutMeItem> PostItems { get; set; } = null!;
}
