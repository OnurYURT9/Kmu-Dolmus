using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KmuDolmus.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-JA53S8S;database=kmudolmus2; integrated security=true;");
        }
        
        
        public DbSet<Gun> Guns { get; set; }
        public DbSet<Hatlar> Hatlars { get; set; }


    }
}
