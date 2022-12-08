using ComicBookCollection.Business;
using ComicBookCollection.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ComicBookCollection.Controllers
{
    [ApiController]
    [Route("/api/Comics")]
    public class ComicsController : Controller
    {
        private readonly IComicsService _comicsService;

        public ComicsController(IComicsService comicsService)
        {
            _comicsService = comicsService;
        }

        [HttpGet]
        [Route("/")]
        public IEnumerable<Comic> GetAllComics()
        {
            return _comicsService.GetAllComics();
        }

        [HttpGet]
        [Route("/:id")]
        public Comic GetComicById([FromQuery] Guid Id)
        {
            return _comicsService.GetComicById(Id);
        }
    }
}
