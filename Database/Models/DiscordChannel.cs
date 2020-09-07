using System.Collections.Generic;

namespace Database.Models
{
  public class DiscordChannel
  {
    public int DiscordChannelId { get; set; }

    public List<DiscordUser> DiscordUsers { get; set; }
  }
}