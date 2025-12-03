using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR.Models
{
    public class EmployeeAttendance
    {
        int _employeeID;
        DateTime _date;
        string _status;

        public int EmployeeID { get => _employeeID; set => _employeeID = value; }
        public DateTime Date { get => _date; set => _date = value; }
        public string Status { get => _status; set => _status = value; }
    }
}