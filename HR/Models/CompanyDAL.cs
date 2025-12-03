using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;

namespace HR.Models
{
    public class CompanyDAL
    {
        public void InsertCompany(Company ObjCompany)
        {
            string _connectionString = ConfigurationManager.ConnectionStrings["dberp"].ToString();
            const string sql = "INSERT INTO [dbo].[Company] ([CompanyName], [Address], [Email]) VALUES (@CompanyName, @Address, @Email)";

            using (var con = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.Add(new SqlParameter("@CompanyName", System.Data.SqlDbType.NVarChar, 50) { Value = (object)ObjCompany.CompanyName ?? DBNull.Value });
                cmd.Parameters.Add(new SqlParameter("@Address", System.Data.SqlDbType.NVarChar, 50) { Value = (object)ObjCompany.Address ?? DBNull.Value });
                cmd.Parameters.Add(new SqlParameter("@Email", System.Data.SqlDbType.NVarChar, 50) { Value = (object)ObjCompany.Email ?? DBNull.Value });

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}