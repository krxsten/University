using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using university.Data.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace university.Data
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext() : base()
        {

        }
        public DbSet<University> Universities { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Major> Majors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=STUDENT14;Database=univeristyDB;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
