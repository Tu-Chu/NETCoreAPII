using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KLKLKL.Models;

namespace Tcontext.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<KLKLKL.Models.cau1> cau1 { get; set; } = default!;
        public DbSet<KLKLKL.Models.Student> Student { get; set; } = default!;
    }
}
