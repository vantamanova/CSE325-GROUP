// represents the shared game information
namespace CSE325_GROUP.Models;

public class Game
{
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public int? ReleaseYear { get; set; }

    public string Platform { get; set; } = string.Empty;

    public string Genre { get; set; } = string.Empty;

    public string CoverImage { get; set; } = string.Empty;
}