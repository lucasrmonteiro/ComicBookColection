using System.Text.Json;
using ComicBookCollection.Data.Entities;

namespace ComicBookCollection.Data.Repository;

public class ComicsRepository : IComicsRepository
{
    private string dataPath = Path.Combine(Environment.CurrentDirectory, @"..\\ComicBookCollection.Data\", "data.json");

    public IEnumerable<Comic> GetAll()
    {

        using (StreamReader r = new StreamReader(@"..\\ComicBookCollection.Data\data.json"))
        {
            string json = r.ReadToEnd();
            return JsonSerializer.Deserialize<IEnumerable<Comic>>(json) ?? new List<Comic>();
        }
    }

    public Comic GetById(Guid id)
    {
        using (StreamReader r = new StreamReader(dataPath))
        {
            string json = r.ReadToEnd();
            var list = JsonSerializer.Deserialize<IEnumerable<Comic>>(json) ?? new List<Comic>();
            return list.SingleOrDefault(It => It.Id == id);
        }
    }
}