using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CSE325_GROUP.Models;

namespace CSE325_GROUP.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
    : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Game> Games { get; set; }

    public DbSet<UserGame> UserGames { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<UserGame>()
            .HasKey(ug => new { ug.UserId, ug.GameId });
    }
}