using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entitylayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace dataaccesslayer.Concrete
{
    public class context:IdentityDbContext<WriterUser,WriterRole,int>

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-Q7REHJH\\SQLEXPRESS; database=dbcoreproje; integrated security=true");
            //Database Bağlantı İşlemi
        }
        public DbSet <About> abouts { get; set; }
        public DbSet<contact> contacts { get; set; }
        public DbSet<exprerience> expreriences { get; set; }
        public DbSet<Feature> feathures { get; set; }
        public DbSet<message> messages { get; set; }
        public DbSet<portfolio> portfolios { get; set; }
        public DbSet<service> services { get; set; }
        public DbSet<skill> skills { get; set; }
        
        public DbSet<socialmedia> socialmedias { get; set; }
        public DbSet<testimonial> testimonial { get; set; }
        public DbSet<todolist> todolists { get; set; }
        public DbSet<user> users { get; set; }

        public DbSet<usermessage> usermessages { get; set; }

    }
}
