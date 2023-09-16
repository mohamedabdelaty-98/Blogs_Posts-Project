using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Models
{
    public class Task2_DbContext:DbContext
    {
        public virtual DbSet<Post> posts { get; set; }
        public virtual DbSet<Author> authors { get; set; }
        public virtual DbSet<Catalog> catalogs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=BLOGSDB;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
