using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.ViewModel.StoreViewModel.ProductDetail
{
    public class ProductDetailViewModel
    {
        public string ID { get; set; } = "";
        public string Product { get; set; } = "";
        public List<string> Description { get; set; } = [];
        public DateTime Warranty { get; set; } = DateTime.Now;
        public string Origin { get; set; } = "";
        public string AdditionalImage { get; set; } = "";
    }
}
