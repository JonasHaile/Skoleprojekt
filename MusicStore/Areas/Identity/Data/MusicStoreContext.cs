using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MusicStore.Areas.Identity.Data;
using MusicStore.Models;

namespace MusicStore.Data;

public class MusicStoreContext : IdentityDbContext<MusicStoreUser>
{
    public MusicStoreContext(DbContextOptions<MusicStoreContext> options)
        : base(options)
    {
    }

    public DbSet <Album > Album { get; set; }
    public DbSet <Artist > Artist { get; set; }
    public DbSet<Genre > Genre { get; set; }
    public DbSet <Playlist > Playlist { get; set; }
    public DbSet <Song> Song { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
