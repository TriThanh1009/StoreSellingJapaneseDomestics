using SSJD.Entities.GeneralEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.ViewModel.StoreViewModel.Product
{
    public class ProductRequestModel
    {
        public string Name { get; set; } = "";
        public string Brand { get; set; } = "";
        public string CategoryID { get; set; } = "";
        public decimal Price { get; set; } = 0;
        public int Stock { get; set; } = 0;
        public Active isActive { get; set; } = Active.No;
        public string Image { get; set; } = "";
    }
}
