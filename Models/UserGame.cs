using CSE325_GROUP.Data;

namespace CSE325_GROUP.Models;

public class UserGame
{
    public string UserId { get; set; } = string.Empty;

    public int GameId { get; set; }

    public string Status { get; set; } = string.Empty;

    public int? Rating { get; set; }

    public ApplicationUser User { get; set; } = null!;

    public Game Game { get; set; } = null!;
}