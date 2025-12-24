namespace GameDevPortfolio.Models;

public class Game
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public int DeveloperId { get; set; }
    public Developer? Developer { get; set; }
}
