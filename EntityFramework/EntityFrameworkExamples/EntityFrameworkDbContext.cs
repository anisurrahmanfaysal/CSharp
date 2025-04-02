using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExamples
{
    public class EntityFrameworkDbContext : DbContext
    {
        private readonly string _connectionString = "Server=DESKTOP-5IJV2CO\\SQLEXPRESS;Database=EntityFrameWorkExamples;User Id=entityframeworkexamples;Password=123456;Trust Server Certificate=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(_connectionString);

            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Course> Courses { get; set; }
    }
}
