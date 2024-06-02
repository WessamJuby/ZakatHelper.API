using Microsoft.EntityFrameworkCore;

namespace ZakatHelper.Data
{
    public class ZakatDbContext : DbContext
    {
        public ZakatDbContext(DbContextOptions<ZakatDbContext> dbContextOptions) : base(dbContextOptions)
        {
                
        }
    }
}
