using SSJD.Entities.GeneralEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.ViewModel.StoreViewModel.Order
{
    public class OrderViewModel
    {
        public string ID { get; set; } = "";
        public string User { get; set; } = "";
        public string CustomerName { get; set; } = "";
        public string CustomerPhone { get; set; } = "";
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public string ShippingUnit { get; set; } = "";
        public string ShippingAddress { get; set; } = "";
        public string OrderStatus { get; set; } = "";
        public decimal TotalPrice { get; set; } = 0;
        public string PaymentMethod { get; set; } = "";
        public Active PaymentStatus { get; set; } = Active.No;
    }
}
