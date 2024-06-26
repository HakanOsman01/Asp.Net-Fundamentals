using Eventmi.Core.ViewModels;
using Eventmi.Infrastructer.Models;

namespace Eventmi.Core.Contracts
{
    public interface IEventService
    {
        Task AddEventAsync(EventModel eventModel);
        Task<IEnumerable<EventModel>> GetAllEventsAsync();
        Task  EditEventAsync(EventModel eventModel,Event eventmodel);
        Task DeleteEventAsync(Event eventmodel);
        Task <Event?> GetByIdAsync(int id);
    }
}
