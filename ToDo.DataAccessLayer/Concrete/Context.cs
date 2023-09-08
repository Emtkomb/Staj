
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.EntityLayer.Concrete;

namespace ToDo.DataAccessLayer.Concrete
{
    public class Context:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-ACGE14T\\SQLEXPRESS;initial catalog=ApiDb;integrated security=true;TrustServerCertificate=True");
        }
        public DbSet<todo> Todos { get; set; }
    }
}
