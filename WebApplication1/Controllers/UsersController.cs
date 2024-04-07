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
    public class UsersController : ApiController
    {
        private MyDbContext _context = new MyDbContext();

        // GET: api/Users
        public IEnumerable<User> Get()
        {
            return _context.Users.ToList();
        }

        // GET: api/Users/5
        public IHttpActionResult Get(int id)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        // GET: api/Users/Filial?equipmentId=1
        [System.Web.Http.Route("api/Users/Filial")]
        public IHttpActionResult GetFilialByEquipment(int equipmentId)
        {
            var equipment = _context.Equipment.FirstOrDefault(e => e.Id == equipmentId);
            if (equipment == null)
            {
                return NotFound();
            }
            var filial = _context.Filial.FirstOrDefault(f => f.Name == equipment.filial);
            if (filial == null)
            {
                return NotFound();
            }
            return Ok(filial);
        }
    }

}