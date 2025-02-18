using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Entities.StoreEntity
{
    public class Order
    {
        public string ID { get; set; } = "";
        public string UserID { get; set; } = "";
        public string CustomerName { get; set; } = "";  
        public string CustomerAddress { get; set; } = "";
        public string CustomerPhone { get; set; } = "";
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public string ShippingUnitID { get; set; } = "";
        public DateTime ShippingDate { get; set; } = DateTime.Now;
        public string ShippingAddress { get; set; } = "";
        public string OrderStatus { get; set; } = "";
        public decimal TotalPrice { get; set; } = 0;
        public string PaymentMethod { get; set; } = "";
        public string PaymentStatus { get; set; } = "";

        public User User { get; set; } 
        public UnitShip UnitShip { get; set; } 
        public OrderDetail OrderDetail { get; set; }

    }
}
