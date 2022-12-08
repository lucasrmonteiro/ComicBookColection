using ComicBookCollection.CrossCutting.Enum;
namespace ComicBookCollection.Data.Entities;

public class Comic
{
    public Guid Id { get; set; }
    public required string Title { get; set; }
    public required string PublishingCompany { get; set; }
}