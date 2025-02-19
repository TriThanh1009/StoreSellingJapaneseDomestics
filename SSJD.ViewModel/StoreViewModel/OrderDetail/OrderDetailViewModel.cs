using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.ViewModel.StoreViewModel.OrderDetail
{
    public class OrderDetailViewModel
    {
        public string ID { get; set; } = "";
        public string OrderID { get; set; } = "";
        public string ProductID { get; set; } = "";
        public string HeadType { get; set; } = "";
        public string UnitProduct { get; set; } = "";
        public decimal UnitPrice { get; set; } = 0;
        public int Quantity { get; set; } = 0;
        public decimal Subtotal { get; set; } = 0;
        public string Promotion { get; set; } = "";
    }
}
