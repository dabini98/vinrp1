using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.Entity;

namespace webapp_asp.Models
{
    public class Menu
    {
        [Key]
        public string number { get; set; }
        public string name { get; set; } 

        public int amount {get; set;}       
 
        public int price {get; set; }

        public int sales {get; set; }

    }
     public class MenuContext : DbContext
    {
        public MenuContext() : base("MsSQLConnection") { }
        public DbSet<Menu> MenuModels { get; set; }
    }
}
