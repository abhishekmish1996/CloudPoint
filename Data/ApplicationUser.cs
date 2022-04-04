using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CloudPoint.Data
{
    [NotMapped]
    public class ApplicationUser : IdentityUser
    {
        public string UserName { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public string CompanyCode { get; set; }
        //public string ContactNumber { get; set; }
        //public string EmployeeID { get; set; }
        //public string Department { get; set; }
    }
}
