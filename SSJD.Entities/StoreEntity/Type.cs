using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Entities.StoreEntity
{
    public class Type
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ProductDetail ProductDetail { get; set; } = null!;
    }
}
