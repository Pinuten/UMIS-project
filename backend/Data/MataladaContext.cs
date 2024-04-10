using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

    public class MataladaContext : DbContext
    {
        public MataladaContext (DbContextOptions<MataladaContext> options)
            : base(options)
        {
        }

        public DbSet<Matlada> Matlada { get; set; } = default!;
    }
