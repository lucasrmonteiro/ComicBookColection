using ComicBookCollection.Data.Entities;

namespace ComicBookCollection.Data.Repository
{
    public interface IComicsRepository
    {
        IEnumerable<Comic> GetAll();
        Comic GetById(Guid id);
    }
}