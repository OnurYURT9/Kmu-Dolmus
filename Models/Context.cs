using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace KmuDolmus.Models
{
    public class Context :IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-JA53S8S;database=DolmuslarKaraman; integrated security=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Guzergah_Durak> Guzergah_Duraks { get; set; }
        public DbSet<Durak> Duraks { get; set; }
        public DbSet<Yon> Yons { get; set; }
        public DbSet<Gun> Guns { get; set; }
        public DbSet<Hatlar> Hatlars { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Guzergah> Guzergahs { get; set; }
        public DbSet<harita> haritas { get; set; }
        public DbSet<Kullanici> Kullanicis { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
       /* public Context(DbContextOptions<Context> options) : base(options) { }*/
    }
}
