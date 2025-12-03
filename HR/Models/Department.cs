using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR.Models
{
    public class Department
    {
        string _departmentname;
        string _departmenthead;
        string _location;

        
        public string Departmenthead { get => _departmenthead; set => _departmenthead = value; }
        public string Location { get => _location; set => _location = value; }
        public string Departmentname { get => _departmentname; set => _departmentname = value; }
    }
}