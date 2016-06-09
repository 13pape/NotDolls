using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotDolls.Models
{
    public class NotDollsContext: DbContext
    {
        public NotDollsContext(DbContextOptions<NotDollsContext> options)
            : base(options)
        { }

        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Geek> Geek { get; set; }
        public DbSet<InventoryImage> InventoryImage { get; set; }

    }
}
