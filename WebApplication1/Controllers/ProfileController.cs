using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProfileController : ApiController
    {
        private MyDbContext _context = new MyDbContext();

        // GET: api/Profile
        public IEnumerable<Profile> Get()
        {
            return _context.Profile.ToList();
        }

        // GET: api/Profile/5
        public IHttpActionResult Get(int id)
        {
            var profile = _context.Profile.FirstOrDefault(p => p.Id == id);
            if (profile == null)
            {
                return NotFound();
            }
            return Ok(profile);
        }
    }
}