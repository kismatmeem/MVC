using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HR.Models
{
    public class DepartmentDAL
    {
        public void InsertDepartment(Department ObjDepartment)
        {
            string _connectionString = ConfigurationManager.ConnectionStrings["dberp"].ToString();
            const string sql = "INSERT INTO [dbo].[Department] ([DepartmentName], [DepartmentHead], [Location]) VALUES (@DepartmentName, @DepartmentHead, @Location)";

            using (var con = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.Add(new SqlParameter("@DepartmentName", System.Data.SqlDbType.VarChar, 50) { Value = (object)ObjDepartment.Departmentname ?? DBNull.Value });
                cmd.Parameters.Add(new SqlParameter("@DepartmentHead", System.Data.SqlDbType.VarChar, 50) { Value = (object)ObjDepartment.Departmenthead ?? DBNull.Value });
                cmd.Parameters.Add(new SqlParameter("@Location", System.Data.SqlDbType.VarChar, 50) { Value = (object)ObjDepartment.Location ?? DBNull.Value });

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}