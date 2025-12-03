using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace HR.Models
{
    public class DesignationDAL
    {
        public void InsertDesignation(Designation ObjDesignation)
        {
            string _connectionString = ConfigurationManager.ConnectionStrings["dberp"].ToString();
            const string sql = "INSERT INTO [dbo].[Designation] ([DesignationName], [Department], [Email]) VALUES (@DesignationName, @Department, @Email)";

            using (var con = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.Add(new SqlParameter("@DesignationName", System.Data.SqlDbType.VarChar, 50) { Value = (object)ObjDesignation.DesignationName ?? DBNull.Value });
                cmd.Parameters.Add(new SqlParameter("@Department", System.Data.SqlDbType.VarChar, 50) { Value = (object)ObjDesignation.Department ?? DBNull.Value });
                cmd.Parameters.Add(new SqlParameter("@Email", System.Data.SqlDbType.VarChar, 50) { Value = (object)ObjDesignation.Email ?? DBNull.Value });

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}