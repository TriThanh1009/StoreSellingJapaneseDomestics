using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Entities.StoreEntity
{
    public class OrderDetail
    {
        public string ID { get; set; } = "";
        public string OrderID { get; set; } = "";
        public string ProductID { get; set; } = "";
        public string HeadType { get; set; } = "";
        public int Quantity { get; set; } = 0;
        public decimal Subtotal { get; set; } = 0;
        public string PromotionID { get; set; } = "";

         

        public Order Order { get; set; } 
        public Product Product { get; set; }

        public Promotion Promotion { get; set; } 
    }
}
