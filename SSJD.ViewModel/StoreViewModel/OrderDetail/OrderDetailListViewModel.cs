using SSJD.ViewModel.StoreViewModel.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.ViewModel.StoreViewModel.OrderDetail
{
    public class OrderDetailListViewModel
    {
        public string OrderID { get; set; }
        public List<OrderDetailViewModel> OrderDetails { get; set; }
    }
}
