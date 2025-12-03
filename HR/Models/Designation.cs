using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR.Models
{
    public class Designation
    {
        string _designationName;
        string _department;
        string _email;

        public string DesignationName { get => _designationName; set => _designationName = value; }
        public string Department { get => _department; set => _department = value; }
        public string Email { get => _email; set => _email = value; }
    }
}