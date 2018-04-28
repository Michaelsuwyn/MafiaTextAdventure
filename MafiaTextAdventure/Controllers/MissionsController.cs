using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MafiaTextAdventure.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MafiaTextAdventure.Controllers
{
    [Route("api/[controller]")]
    public class MissionsController : Controller
    {
        private MafiaTextAdventureContext _context;

        public MissionsController(MafiaTextAdventureContext context)
        {
            _context = context;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Mission> Get()
        {
            return _context.Missions.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Mission Get(int id)
        {
            return _context.Missions.SingleOrDefault<Mission>(mission => mission.Id == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Mission mission)
        {
            _context.Missions.Add(mission);
            _context.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Mission mission)
        {
            mission.Id = id;
            _context.Update(mission);
            _context.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Mission deleter = _context.Missions.SingleOrDefault<Mission>(mission => mission.Id == id);
            _context.Missions.Remove(deleter);
            _context.SaveChanges();
        }
    }
}
