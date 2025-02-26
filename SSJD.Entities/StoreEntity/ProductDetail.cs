using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Entities.StoreEntity
{
    public class ProductDetail
    {
        public string ID { get; set; } = "";
        public string ProductID { get; set; } = "";
        public string HeadType { get; set; } = "";
        public List<string> Description { get; set; } = [];
        public DateTime Warranty { get; set; } = DateTime.Now;
        public string Origin { get; set; } = "";

        public Product Product { get; set; } 
    }
}
