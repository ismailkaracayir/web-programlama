using sevimlidostlar.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sevimlidostlar.dataAccessLayer
{
   public class DatabaseContext : DbContext
    {
        public DbSet<sevimlidostlarUser> SevimlidostlarUsers { get; set; }
        public DbSet<Kategori> kategori { get; set; }
        public DbSet<Hayvanlar> hayvanlars { get; set; }
        public DbSet<Comment> comments { get; set; }



    }
}
