using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnKey.Model.ViewModels;

namespace TurnKey.DAL.Interface
{
     public interface ILoginDAL
    {

        List<UserDetailVM> GetUserDetail(string userName, string password);

        List<MenuBar> GetUserPermissionMatrix(string userName);
      
    }
}
