using Microsoft.EntityFrameworkCore;
using StudentFormApp.Models;
using System.Collections.Generic;

namespace StudentFormApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<StudentModel> Students { get; set; }
    }
}
