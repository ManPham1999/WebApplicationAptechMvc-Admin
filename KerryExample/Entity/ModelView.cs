using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KerryExample.Entity
{
  public class ModelView
  {

    public List<Catgory> catgories { get; set; }
    public List<Product> products { get; set; }
    public Product product { get; set;  }
    public string routeParamsString { get; set; }
    public Guid routeParamsUnique { get; set; }
  }
}