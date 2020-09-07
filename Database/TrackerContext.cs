using Microsoft.EntityFrameworkCore;
using Database.Models;

namespace Database
{
  public class TrackerContext : DbContext
  {
    public DbSet<Player> Players { get; set; }
    public DbSet<Character> Characters { get; set; }
    public DbSet<DiscordChannel> DiscordChannels { get; set; }
    public DbSet<DiscordUser> DiscordUsers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      => optionsBuilder.UseNpgsql("Host=localhost;Database=poe-tracker;Username=nate;Password=admin");
  }
}
