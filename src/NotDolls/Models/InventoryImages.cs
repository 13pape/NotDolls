using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotDolls.Models
{
    public class InventoryImage
    {
        public int InventoryImageId { get; set; }
        public int InventoryId { get; set; }
        public string Image { get; set; }
        public string MetaData { get; set; }

        public Inventory Inventory { get; set; }
    }
}
