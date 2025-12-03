using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR.Models
{
    public class Company
    {
        string _companyName;
        string _address;
        string _email;

        public string CompanyName { get => _companyName; set => _companyName = value; }
        public string Address { get => _address; set => _address = value; }
        public string Email { get => _email; set => _email = value; }
    }
}