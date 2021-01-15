using System;

namespace KerryExample.Entity
{
    public class CartLine
    {
        public Guid ID { get; set; }
        public string CartRefId { get; set; }
        public Cart Cart { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public bool IsActive { get; set; }
    }
}