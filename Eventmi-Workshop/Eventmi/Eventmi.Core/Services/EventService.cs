using Eventmi.Core.Contracts;
using Eventmi.Core.ViewModels;
using Eventmi.Infrastructer.Data;
using Eventmi.Infrastructer.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;

namespace Eventmi.Core.Services
{
    public class EventService : IEventService
    {
        private readonly EventmiDbContext context;
        public EventService(EventmiDbContext _context)
        {
            context = _context;
        }

        public async Task AddEventAsync(EventModel eventModel)
        {
            var entity = new Event()
            {
                Name = eventModel.Name,
                Place = eventModel.Place,
                Start = eventModel.Start,
                End = eventModel.End,
            };
            await context.Events.AddAsync(entity);
            await context.SaveChangesAsync();
           
        }

        public async Task DeleteEventAsync(Event eventmodel)
        {
            context.Events.Remove(eventmodel);
            await context.SaveChangesAsync();   
            
        }

        public async Task EditEventAsync(EventModel eventModel,Event eventmodel)
        {
            eventmodel.Name = eventModel.Name;
            eventmodel.Place = eventModel.Place;
            eventmodel.Start = eventModel.Start;
            eventmodel.End = eventModel.End;
            await context.SaveChangesAsync();
        }

        

        public async Task<IEnumerable<EventModel>> GetAllEventsAsync()
        {
           return await context.Events.Select(e=> new EventModel()
           {
               Name = e.Name,
               Place = e.Place,
               Start = e.Start,
               End = e.End,
               
           }).ToListAsync();
        }

        public Task<Event?> GetByIdAsync(int id)
        {
           var entity = context.Events.FirstOrDefaultAsync(e=>e.Id == id);
           return entity;
        }
    }
}
