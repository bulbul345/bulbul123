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
    public class FinalBookingController : ControllerBase
    {
        MovieDBContext db;
        public FinalBookingController(MovieDBContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<FinalBooking> GetFinalOrder()
        {
            return db.FinalBookings;
        }
        [HttpPost]
        public string post([FromBody] FinalBooking ct)
        {
            db.FinalBookings.Add(ct);
            db.SaveChanges();
            return "Success";
        }
    }
}