using Microsoft.AspNetCore.Mvc;
using TP_MOD_10_103022400031.Models;

namespace TP_MODUL10_103022400031.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private static List<Film> dataFilm = new List<Film>
        {
            new Film { Judul = "Inception", Sutradara = "Christopher Nolan", Tahun = "2010", Genre = "Sci-Fi", Rating = "9.0" },
            new Film { Judul = "Interstellar", Sutradara = "Christopher Nolan", Tahun = "2014", Genre = "Sci-Fi", Rating = "8.7" },
            new Film { Judul = "Parasite", Sutradara = "Bong Joon-ho", Tahun = "2019", Genre = "Thriller", Rating = "8.6" }
        };

        [HttpGet]
        public IEnumerable<Film> Get()
        {
            return dataFilm;
        }

        [HttpGet("{id}")]
        public ActionResult<Film> Get(int id)
        {
            int index = id - 1; 
            if (index < 0 || index >= dataFilm.Count)
            {
                return NotFound("Film tidak ditemukan.");
            }
            return dataFilm[index];
        }

        [HttpPost]
        public IActionResult Post([FromBody] Film newFilm)
        {
            dataFilm.Add(newFilm);
            return Ok("Film berhasil ditambahkan.");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            int index = id - 1;
            if (index < 0 || index >= dataFilm.Count)
            {
                return NotFound("Film tidak ditemukan.");
            }
            dataFilm.RemoveAt(index);
            return Ok("Film berhasil dihapus.");
        }
    }
}