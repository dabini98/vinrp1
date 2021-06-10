using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Data.SqlClient;

namespace webapp_asp.Models
{
    public class Member
    {
        [Key]
        public string id { get; set; }
        public string password { get; set; } 

        public string yourname {get; set;}       
 
        public string phonenumber {get; set; }
        public string address {get; set; }
    }
}
