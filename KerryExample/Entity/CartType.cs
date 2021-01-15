using System;
using System.Collections.Generic;

namespace KerryExample.Entity
{
    public class CartType
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Cart> Carts { get; set; }
        public bool IsActive { get; set; }
    }
}