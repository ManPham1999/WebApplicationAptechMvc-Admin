using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KerryExample.Entity
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string  Password { get; set; }
        public bool IsActive { get; set; }
        public bool Gender { get; set; }
        public List<Cart> Carts { get; set; }
    }
}