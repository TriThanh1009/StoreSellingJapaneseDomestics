using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Entities.StoreEntity
{
    public class Brand
    {
        public string ID { get; set; } = "";
        public string Name { get; set; } = "";

        public List<Product> Product { get; set; }
    }
}
