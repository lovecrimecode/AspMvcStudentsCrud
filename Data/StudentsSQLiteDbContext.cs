using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppMvcCrudProg.Models;

namespace WebAppMvcCrudProg.Data
{
    public class StudentsSQLiteDbContext : DbContext
    {
        public StudentsSQLiteDbContext (DbContextOptions<StudentsSQLiteDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppMvcCrudProg.Models.Student> Student { get; set; } = default!;
    }
}
