using ComicBookCollection.Data.Entities;
using ComicBookCollection.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBookCollection.Business
{
    public class ComicsService : IComicsService
    {
        private readonly IComicsRepository _comicsRepository;
        public ComicsService(IComicsRepository comicsRepository)
        {
            _comicsRepository = comicsRepository;
        }

        public IEnumerable<Comic> GetAllComics()
        {
            return _comicsRepository.GetAll();
        }

        public Comic GetComicById(Guid Id)
        {
            return _comicsRepository.GetById(Id);
        }
    }
}
