using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TurnKey.Model.Models;
using TurnKey.Model.ViewModels;

namespace TurnKey.DAL.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<TemplateBucket> templateBucket { get; set; }
        public DbSet<Templates> template { get; set; }
        public DbSet<LoginVM> LoginVMs { get; set; }
        public DbSet<ProspectRegistered>  ProspectRegistereds { get; set; }
        public DbSet<state> state { get; set; }
        public DbSet<eventThemes> eventTheme { get; set; }
    }

    public static class CommanHelpers
    {

        /// <summary>
        ///  Load Store Procedure without parameter
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public static DbCommand LoadStoredProc(this DbContext context, string storedProcName)
        {
            var cmd = context.Database.GetDbConnection().CreateCommand();
            cmd.CommandText = storedProcName;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            return cmd;
        }

        /// <summary>
        ///  Load Store Procedure With int parameter
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public static DbCommand LoadStoredProcGetById(this DbContext context, string storedProcName, int prms)
        {
            var cmd = context.Database.GetDbConnection().CreateCommand();
            cmd.CommandText = storedProcName;
            cmd.Parameters.Add(prms);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            return cmd;
        }

        /// <summary>
        ///  Load Store Procedure With array parameter
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public static DbCommand LoadStoredProcWithData(this DbContext context, string storedProcName, SqlParameter[]  prms)
        {
            var cmd = context.Database.GetDbConnection().CreateCommand();
            cmd.CommandText = storedProcName;
            cmd.Parameters.AddRange(prms);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            return cmd;
        }

        /// <summary>
        ///  Execute Store Procedure return list
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public static async Task<List<T>> ExecuteStoredProc<T>(this DbCommand command)
        {
            using (command)
            {
                if (command.Connection.State == System.Data.ConnectionState.Closed)
                    command.Connection.Open();
                try
                {
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        return reader.MapToList<T>();
                    }
                }
                catch (Exception e)
                {
                    throw (e);
                }
                finally
                {
                    command.Connection.Close();
                }
            }
        }
        private static List<T> MapToList<T>(this DbDataReader dr)
        {
            var objList = new List<T>();
            var props = typeof(T).GetRuntimeProperties();

            var colMapping = dr.GetColumnSchema().Where(x => props.Any(y => y.Name.ToLower() == x.ColumnName.ToLower())).ToDictionary(key => key.ColumnName.ToLower());

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    T obj = Activator.CreateInstance<T>();
                    foreach (var prop in props)
                    {
                        var val =
                          dr.GetValue(colMapping[prop.Name.ToLower()].ColumnOrdinal.Value);
                        prop.SetValue(obj, val == DBNull.Value ? null : val);
                    }
                    objList.Add(obj);
                }
            }
            return objList;
        }

        /// <summary>
        ///  Execute Store Procedure with array parameter
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public static int ExecuteStoredProc(this DbCommand command)
        {
            using (command)
            {
                if (command.Connection.State == System.Data.ConnectionState.Closed)
                    command.Connection.Open();
                try
                {
                    int result= command.ExecuteNonQuery();
                    return result;
                }
                catch (Exception e)
                {
                    throw (e);
                }
                finally
                {
                    command.Connection.Close();
                }
            }
        }

        /// <summary>
        ///  Execute Store Procedure with array parameter
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>




        public static DbCommand WithSqlParam(this DbCommand cmd, string paramName, object paramValue)
        {
            if (string.IsNullOrEmpty(cmd.CommandText))
                throw new InvalidOperationException("Call LoadStoredProc before using this method");
            var param = cmd.CreateParameter();
            param.ParameterName = paramName;
            param.Value = paramValue;
            cmd.Parameters.Add(param);
            return cmd;
        }



    }
}
