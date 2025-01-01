using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Entities.CustomerEntity
{
    public class MemberCard
    {
        public int ID { get; set; }
        public int Point { get; set; }
        public string MemberClass { get; set; }
        public decimal Discount { get; set; }
    }
}
