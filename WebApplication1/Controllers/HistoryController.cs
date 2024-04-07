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
    public class HistoryController : ApiController
    {
        private MyDbContext _context = new MyDbContext();

        // GET: api/History
        public IEnumerable<History> Get()
        {
            return _context.History.ToList();
        }

        // GET: api/History/5
        public IHttpActionResult Get(int id)
        {
            var historyItem = _context.History.FirstOrDefault(h => h.id == id);
            if (historyItem == null)
            {
                return NotFound();
            }
            return Ok(historyItem);
        }
    }

   
}