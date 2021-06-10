using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Menu = webapp_asp.Models.Menu;

namespace webapp_asp.Data 
{
    public class MenuContext : DbContext
    {
        public MenuContext(DbContextOptions<MenuContext> options) : base(options)
        { 
        }
        public DbSet<Menu> Menu { get; set; }
    }
}
