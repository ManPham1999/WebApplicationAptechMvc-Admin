using System;
using System.Collections.Generic;

namespace KerryExample.Entity
{
  public class ModelView
  {

    public IEnumerable<Catgory> catgories { get; set; }
    public IEnumerable<Product> products { get; set; }
    public IEnumerable<Cart> transactions { get; set; }
    public Product product { get; set;  }
    public Catgory catgory { get; set;  }
    public string routeParamsString { get; set; }
    public Guid routeParamsUnique { get; set; }
  }
}