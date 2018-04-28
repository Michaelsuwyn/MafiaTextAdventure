using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MafiaTextAdventure.Models
{
    public class MafiaTextAdventureContext : DbContext
    {
        public MafiaTextAdventureContext(DbContextOptions<MafiaTextAdventureContext> options) : base(options)
        {

        }
        public DbSet<Player> Players { get; set; }
        public DbSet<Mission> Missions { get; set; }
    }
}
