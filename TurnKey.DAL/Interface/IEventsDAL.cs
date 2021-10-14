using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnKey.Model.Models;
using TurnKey.Model.ViewModels;

namespace TurnKey.DAL.Interface
{
   public interface IEventsDAL
    {
        Task<List<Event>> GetAllEvents(Guid userId, string userRole, int Delear);
        Task<int> CreateEvents(Event events);
        Task<List<EventTypeVM>> Manufacturer();
        Task<int> AddEventTheme(SqlParameter[] prms);
        Task<int> DeleteEventTheme(SqlParameter[] prms);
        Task<List<state>> State();
        Task<List<eventThemes>> EventTheme();
        Task<int> AddEventType(SqlParameter[] prms);
        Task<int> DeleteEventType(SqlParameter[] prms);
       
    }
}
