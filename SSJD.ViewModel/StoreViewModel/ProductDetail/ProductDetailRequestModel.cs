using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.ViewModel.StoreViewModel.ProductDetail
{
    public class ProductDetailRequestModel
    {
        public string ProductID { get; set; } = "";
        public string Description { get; set; } = "";
        public DateTime Warranty { get; set; } = DateTime.Now;
        public string Origin { get; set; } = "";
        public string AdditionalImage { get; set; } = "";
    }
}
