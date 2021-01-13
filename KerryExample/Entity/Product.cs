using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace KerryExample.Entity
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public bool Status { get; set; }
        public double Quantity { get; set; }
        public string Img { get; set; }
        public string Desc { get; set; }
        public string CatgoryRefId { get; set; }
        public Catgory Catgory { get; set; }
    }
}
