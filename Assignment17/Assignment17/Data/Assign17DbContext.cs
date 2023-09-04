using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assignment17.Models;

namespace Assignment17.Data
{
    public class Assign17DbContext : DbContext
    {
        public Assign17DbContext (DbContextOptions<Assign17DbContext> options)
            : base(options)
        {
        }

        public DbSet<Assignment17.Models.Movie> Movie { get; set; } = default!;
    }
}
