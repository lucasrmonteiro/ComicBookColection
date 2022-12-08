using ComicBookCollection.Data.Entities;

namespace ComicBookCollection.Business
{
    public interface IComicsService
    {
        IEnumerable<Comic> GetAllComics();
        Comic GetComicById(Guid Id);
    }
}