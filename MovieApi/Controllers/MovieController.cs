using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        MovieDBContext db;
        public MovieController(MovieDBContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<AddMovie> GetAddMovies()
        {
            return db.AddMovies;

            


        }

    }
}
