using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.ViewModel.StoreViewModel.Order
{
    public class OrderViewModel
    {
        public string ID { get; set; }
        public string Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShippingUnit { get; set; }
        public DateTime ShippingDate { get; set; }
        public string ShippingAddress { get; set; }
        public string OrderStatus { get; set; }
        public decimal TotalPrice { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentStatus { get; set; }
    }
}
