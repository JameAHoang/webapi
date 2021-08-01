using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_Demo.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext( DbContextOptions<StudentContext> options) : base(options)
        {
        }
        public DbSet<Students> Students { get; set; }
        public DbSet<Teacher> Teacher { get; set; }

     
    }
}
