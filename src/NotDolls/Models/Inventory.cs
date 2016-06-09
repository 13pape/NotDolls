using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotDolls.Models
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        public string Name { get; set; }
        public string InventoryDescription { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public int Year { get; set; }
        public string Quality { get; set; }
        public DateTime CreatedDated { get; set; }
        public bool Sold { get; set; }
        public int GeekId { get; set; }

        public Geek Geek { get; set; }
        public ICollection<InventoryImage> ActionShots { get; set; }

    }
}
