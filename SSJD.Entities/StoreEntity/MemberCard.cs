using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Entities.StoreEntity
{
    public class MemberCard
    {
        public string ID { get; set; } = "";
        public int Point { get; set; } = 0;
        public string MemberClass { get; set; } = "";
        public int Discount { get; set; } = 0;

        public User User { get; set; }
    }
}
