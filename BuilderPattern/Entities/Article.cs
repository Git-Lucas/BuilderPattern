namespace BuilderPattern.Entities;
public class Article
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string? Title { get; set; }
    public string? Introduction { get; set; }
    public string? Body { get; set; }
    public string? Methods { get; set; }
    public string? Conclusion { get; set; }
}
