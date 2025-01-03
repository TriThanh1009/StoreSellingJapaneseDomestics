using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Entities.StoreEntity
{
    public class ProductDetail
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public string Description { get; set; }
        public DateTime Warranty { get; set; }
        public string Origin { get; set; }
        public string AdditionalImage { get; set; }

        public Product Product { get; set; } 
    }
}
