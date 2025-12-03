using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;

namespace HR.Models
{
    public class EmployeeDAL
    {
        public void InsertEmployee(Employee ObjEmployee)
        {
            string _connectionString = ConfigurationManager.ConnectionStrings["dberp"].ToString();
            const string sql = "INSERT INTO [dbo].[Employee] ([Employee Name], [Mobile No], [Email]) VALUES (@EmployeeName, @MobileNo, @Email)";

            using (var con = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.Add(new SqlParameter("@EmployeeName", System.Data.SqlDbType.NVarChar, 50) { Value = (object)ObjEmployee.Name ?? DBNull.Value });
                cmd.Parameters.Add(new SqlParameter("@Email", System.Data.SqlDbType.NVarChar, 50) { Value = (object)ObjEmployee.Email ?? DBNull.Value });
                cmd.Parameters.Add(new SqlParameter("@MobileNo", System.Data.SqlDbType.NVarChar, 50) { Value = (object)ObjEmployee.MobileNo ?? DBNull.Value });

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}