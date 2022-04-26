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
            optionsBuilder.UseSqlServer("server=DESKTOP-JA53S8S;database=DolmuslarKaraman; integrated security=true;");
        }
        public DbSet<Guzergah_Durak> Guzergah_Duraks { get; set; }
        public DbSet<Durak> Duraks { get; set; }
        public DbSet<Yon> Yons { get; set; }
        public DbSet<Gun> Guns { get; set; }
        public DbSet<Hatlar> Hatlars { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Guzergah> Guzergahs { get; set; }

    }
}
