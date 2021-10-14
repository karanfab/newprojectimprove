using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnKey.Model.Models;
using TurnKey.Model.ViewModels;

namespace TurnKey.DAL.Interface
{
    public interface IProspectRegisteredDAL
    {
        Task<List<ProspectRegistered>> GetProspectRegisteredList(string eventPasscode);
        Task<List<EventProspectDetails>> GetEventDetails(string eventPasscode);
        Task<bool> DeleteProspects(string Id);
        Task<List<TemplateBucket>> GetTemplateBucket();
        Task<List<Template>> GetTemplateData(int bucketId);
        Task<List<TemplateContent>> TemplateContent(int templateId);
        Task<List<EventDetailModel>> BindEventDetails(Guid eventID);
        Task<string> GetEventPasscode(Guid eventID);
        Task<string> SavedBulkSMSDetails(List<ActivityHistory> objActivityHistoryArray, string prospectIds, int activityType);

    }
}
