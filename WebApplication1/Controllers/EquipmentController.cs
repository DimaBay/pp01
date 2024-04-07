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
    public class EquipmentController : ApiController
    {
        private MyDbContext _context = new MyDbContext();

        // GET: api/Equipment
        public IEnumerable<Equipment> Get()
        {
            return _context.Equipment.ToList();
        }

        // GET: api/Equipment/5
        public IHttpActionResult Get(int id)
        {
            var equipment = _context.Equipment.FirstOrDefault(e => e.Id == id);
            if (equipment == null)
            {
                return NotFound();
            }
            return Ok(equipment);
        }
    }

    public class FilialController : ApiController
    {
        private MyDbContext _context = new MyDbContext();

        // GET: api/Filial
        public IEnumerable<Filial> Get()
        {
            return _context.Filial.ToList();
        }

        // GET: api/Filial/5
        public IHttpActionResult Get(int id)
        {
            var filial = _context.Filial.FirstOrDefault(f => f.id == id);
            if (filial == null)
            {
                return NotFound();
            }
            return Ok(filial);
        }
    }

    
}
