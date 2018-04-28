using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MafiaTextAdventure.Models;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MafiaTextAdventure.Controllers
{
    [Route("api/[controller]")]
    public class PlayersController : Controller
    {
        private MafiaTextAdventureContext _context;
        
        public PlayersController(MafiaTextAdventureContext context)
        {
            _context = context;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Player> Get()
        {
            return _context.Players.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Player Get(int id)
        {
            return _context.Players.SingleOrDefault<Player>(player => player.Id == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Player player)
        {
            _context.Players.Add(player);
            _context.SaveChanges();

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Player player)
        {
            player.Id = id;
            _context.Update(player);
            _context.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Player deleter = _context.Players.SingleOrDefault<Player>(player => player.Id == id);
            _context.Players.Remove(deleter);
            _context.SaveChanges();
        }
    }
}
