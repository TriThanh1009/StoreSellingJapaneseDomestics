using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSJD.Entities.GeneralEntity;

namespace SSJD.Entities.StoreEntity
{
    public class Product
    {
        public string ID { get; set; } = "";
        public string Name { get; set; } = "";
        public string Brand { get; set; } = "";
        public string CategoryID { get; set; } = "";
        public decimal Price { get; set; } = 0;
        public int Stock { get; set; } = 0;
        public Active isActive { get; set; } = Active.No;
        public string Image { get; set; } = "";

        public Category Category { get; set; } 

        public List<OrderDetail> OrderDetails { get; set; }

        public ProductDetail ProductDetail { get; set; } 

    }
}
