using Microsoft.EntityFrameworkCore;
using PortfolioApi.Models;

namespace PortfolioApi.Interface
{
    public class DBContextPost
    {
        public DbSet<PostItem> PostItem { get; set; }
    }
}
