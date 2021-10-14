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
    public interface ICreateTemplateDAL
    {

        /// <summary>
        /// Get All Bucket List
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>

        Task<List<CreateModel>> GetAllTemplate();

        // delete template image
        int DeleteTemplateImage(SqlParameter[] prms);

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        /// 
        Task<int> DeleteMngTemplate(SqlParameter[] prms);
        /// <summary>
        /// BucketType
        /// </summary>
        /// <returns></returns>
        Task<List<TemplateBucket>> GetTemplateBucket();



        /// <summary>
        /// Save
        /// </summary>
        /// <param name="prms"></param>
        /// <returns></returns>
        /// 
        int SaveTemplate(SqlParameter[] prms);
        /// <summary>
        /// update
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>

        int UpdateTemplate(SqlParameter[] prms);

        /// <summary>
        /// Edit
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<Templates>GetByIdEditTemplate(int Id);
    }
}