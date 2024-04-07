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
    public class InventoryController : ApiController
    {
        private MyDbContext _context = new MyDbContext();

        // GET: api/Inventory
        public IEnumerable<Inventory> Get()
        {
            return _context.Inventory.ToList();
        }

        // GET: api/Inventory/5
        public IHttpActionResult Get(int id)
        {
            var inventoryItem = _context.Inventory.FirstOrDefault(i => i.id == id);
            if (inventoryItem == null)
            {
                return NotFound();
            }
            return Ok(inventoryItem);
        }
    }
}