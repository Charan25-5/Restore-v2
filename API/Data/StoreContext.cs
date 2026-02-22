using API.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class StoreContext(DbContextOptions options) : IdentityDbContext<User>(options)
{
    public required DbSet<Product> Products { get; set; }
    public required DbSet<Basket> Baskets { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<IdentityRole>()
        .HasData(
            new IdentityRole {Id ="d4f14169-eae3-4b3d-93b6-a0601000e09b", ConcurrencyStamp="Member", Name = "Member", NormalizedName = "MEMBER"},
            new IdentityRole {Id ="1ac1b57b-ef60-4b76-a3f4-010b4e582b3e", ConcurrencyStamp="Admin", Name = "Admin", NormalizedName = "ADMIN"}
        );
    }
}
