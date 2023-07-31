using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using connect_four__server.Models;

namespace connect_four__server.Data
{
    public class connect_four__serverContext : DbContext
    {
        public connect_four__serverContext (DbContextOptions<connect_four__serverContext> options)
            : base(options)
        {
        }

        public DbSet<connect_four__server.Models.Player> Player { get; set; } = default!;
    }
}
