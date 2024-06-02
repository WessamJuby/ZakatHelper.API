using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ZakatHelper.Data
{
    public class ZakatAuthDbContext : IdentityDbContext
    {
        public ZakatAuthDbContext(DbContextOptions<ZakatAuthDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var adminRoleId = "0b3f5e8e-2a09-48fb-85c6-65e70b46af2c";
            var userRoleId = "10c43cf9-0ee4-4ef0-a941-8ffa27d43f3a";

            var roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Id = adminRoleId,
                    ConcurrencyStamp = adminRoleId,
                    Name = "admin",
                    NormalizedName = "admin"
                },
                new IdentityRole
                {
                    Id = userRoleId,
                    ConcurrencyStamp = userRoleId,
                    Name = "user",
                    NormalizedName = "user"
                }
            };
            builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}
