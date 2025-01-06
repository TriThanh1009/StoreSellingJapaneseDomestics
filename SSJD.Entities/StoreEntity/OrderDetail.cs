using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Entities.StoreEntity
{
    public class OrderDetail
    {
        public string ID { get; set; }
        public string OrderID { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string PromotionID { get; set; }
        public decimal Subtotal { get; set; }

        public Order Order { get; } = new();

        public Promotion Promotion { get; set; } 
    }
}
