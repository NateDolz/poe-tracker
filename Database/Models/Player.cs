using System.Collections.Generic;

namespace Database.Models
{
  public class Player
  {
    // properties
    public int PlayerId { get; set; }
    public int AccountId { get; set; }

    // relationships
    public List<Character> Characters { get; set; }

    public DiscordUser DiscordUser { get; set; }
  }
}