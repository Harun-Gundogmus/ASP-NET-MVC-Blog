using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-5ETPORJT;database=ReaDB;integrated security=true;");
        }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Blog> Blogs { get; set; }
    }
}
