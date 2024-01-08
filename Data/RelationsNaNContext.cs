using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RelationsNaN.Models;

namespace RelationsNaN.Data
{
    public class RelationsNaNContext : DbContext
    {
        public RelationsNaNContext (DbContextOptions<RelationsNaNContext> options)
            : base(options)
        {
        }

        public DbSet<RelationsNaN.Models.Game> Game { get; set; } = default!;
    }
}
