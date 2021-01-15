using System;
using System.Collections.Generic;

namespace KerryExample.Entity
{
    public class Cart
    {
        public Guid Id { get; set; }
        public string UserRefId { get; set; }
        public User User { get; set; }
        public string CardTypeRefId { get; set; }
        public CartType CardType { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }
}