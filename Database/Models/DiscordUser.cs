using System.Collections.Generic;

namespace Database.Models
{
  public class DiscordUser
  {
    // properties
    public int DiscordUserId { get; set; }
    public string UserName { get; set; }

    // relationships
    public int DiscordChanelId { get; set; }
    public DiscordChannel DiscordChannel { get; set; }

    public int PlayerId { get; set; }
    public Player Player { get; set; }
  }
}