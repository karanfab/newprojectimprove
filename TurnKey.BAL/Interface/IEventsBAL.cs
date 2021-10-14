using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnKey.Model.Models;
using TurnKey.Model.ViewModels;

namespace TurnKey.BAL.Interface
{
   public interface IEventsBAL
    {
        Task<List<Event>> GetAllEvents(string userId, string userRole);
        Task<int> CreateEvents(Event events);

        Task<List<EventTypeVM>> Manufacturer();
        Task<int> AddEventType(string ManufectureName);
        Task<int> DeleteEventType(Guid eventTheme);
        Task<List<state>> State();
        Task<List<eventThemes>> EventTheme();
        Task<int> AddEventTheme(string EventThemeName);
        Task<int> DeleteEventTheme(Guid eventTheme);
    }
}
