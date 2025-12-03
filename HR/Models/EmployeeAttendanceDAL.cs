using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HR.Models
{
    public class EmployeeAttendanceDAL
    {
        public void InsertEmployeeAttendance(EmployeeAttendance ObjEmployeeAttendace)
        {
            string _connectionString = ConfigurationManager.ConnectionStrings["dberp"].ToString();
            const string sql = "INSERT INTO [dbo].[EmployeeAttendance] ([EmployeeID], [Date], [Status]) VALUES (@EmployeeID, @Date, @Status)";

            using (var con = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.Add(new SqlParameter("@EmployeeID", System.Data.SqlDbType.Int) { Value = (object)ObjEmployeeAttendace.EmployeeID ?? DBNull.Value });
                cmd.Parameters.Add(new SqlParameter("@Date", System.Data.SqlDbType.DateTime) { Value = (object)ObjEmployeeAttendace.Date ?? DBNull.Value });
                cmd.Parameters.Add(new SqlParameter("@Status", System.Data.SqlDbType.NVarChar, 50) { Value = (object)ObjEmployeeAttendace.Status ?? DBNull.Value });

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}