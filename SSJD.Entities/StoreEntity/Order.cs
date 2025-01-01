using SSJD.Entities.CustomerEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Entities.StoreEntity
{
    public class Order
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShippingUnitID { get; set; }
        public DateTime ShippingDate { get; set; }
        public string ShippingAddress { get; set; }
        public string OrderStatus { get; set; }
        public decimal TotalPrice { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentStatus { get; set; }

        public List<Customer> Customers { get; } = new();
        public List<UnitShip> UnitShips { get; } = new();
        public OrderDetail OrderDetail { get; set; }

    }
}
