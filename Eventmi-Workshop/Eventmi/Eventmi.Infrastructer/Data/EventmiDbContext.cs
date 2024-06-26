using Eventmi.Infrastructer.Models;
using Microsoft.EntityFrameworkCore;

namespace Eventmi.Infrastructer.Data
{
    public class EventmiDbContext : DbContext
    {
        public EventmiDbContext(DbContextOptions<EventmiDbContext> options)
            :base(options) 
        {
            
        }
        public DbSet<Event> Events { get; set; }

    }
}
