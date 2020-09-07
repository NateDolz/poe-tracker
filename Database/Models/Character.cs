namespace Database.Models
{
  public class Character
  {
    // properties
    public int CharacterId { get; set; }
    public int CharacterName { get; set; }

    // relationships
    public int PlayerId { get; set; }
    public Player Player { get; set; }

  }
}