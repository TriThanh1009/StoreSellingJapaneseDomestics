using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.ViewModel.StoreViewModel.MemberCard
{
    public class MemberCardRequestModel
    {
        public string ID { get; set; } = "";
        public int Point { get; set; } = 0;
        public string MemberClass { get; set; } = "";
        public decimal Discount { get; set; } = 0;
    }
}
