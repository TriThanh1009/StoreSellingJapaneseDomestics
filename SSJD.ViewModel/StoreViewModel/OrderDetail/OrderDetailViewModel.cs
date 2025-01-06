using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.ViewModel.StoreViewModel.OrderDetail
{
    public class OrderDetailViewModel
    {
        public string ID { get; set; }
        public string Product { get; set; }
        public string Description { get; set; }
        public DateTime Warranty { get; set; }
        public string Origin { get; set; }
        public string AdditionalImage { get; set; }
    }
}
