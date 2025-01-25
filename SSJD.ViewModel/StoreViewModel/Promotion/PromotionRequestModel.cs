using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.ViewModel.StoreViewModel.Promotion
{
    public class PromotionRequestModel
    {
        public string Name { get; set; } = "";
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Now;
        public int PercentDiscount { get; set; } = 0;
    }
}
