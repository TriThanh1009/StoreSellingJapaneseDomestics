using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSJD.Entities.GeneralEnity;
using SSJD.Entities.GeneralEntity;

namespace SSJD.Entities.StoreEntity
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string TypeID { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public Active isActive { get; set; } = Active.No;
        public string Image { get; set; }

        public List<Type> Types { get; } = new();

        public ProductDetail ProductDetail { get; set; } = null!;

    }
}
