namespace GameDevPortfolio.Models;

public class Developer
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Bio { get; set; } = string.Empty;

    public ICollection<Game> Games { get; set; } = new List<Game>();
}
