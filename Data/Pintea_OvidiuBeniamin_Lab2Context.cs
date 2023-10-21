using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pintea_OvidiuBeniamin_Lab2.Models;

namespace Pintea_OvidiuBeniamin_Lab2.Data
{
    public class Pintea_OvidiuBeniamin_Lab2Context : DbContext
    {
        public Pintea_OvidiuBeniamin_Lab2Context (DbContextOptions<Pintea_OvidiuBeniamin_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Pintea_OvidiuBeniamin_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Pintea_OvidiuBeniamin_Lab2.Models.Publisher>? Publisher { get; set; }
    }
}
