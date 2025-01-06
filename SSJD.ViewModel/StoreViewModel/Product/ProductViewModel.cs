using SSJD.Entities.GeneralEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.ViewModel.StoreViewModel.Product
{
    public class ProductViewModel
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public Active isActive { get; set; } = Active.No;
        public string Image { get; set; }
    }
}
