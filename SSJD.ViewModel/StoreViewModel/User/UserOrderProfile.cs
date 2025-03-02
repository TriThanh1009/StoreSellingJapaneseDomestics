using SSJD.Entities.StoreEntity;
using SSJD.ViewModel.StoreViewModel.OrderDetail;
using SSJD.ViewModel.StoreViewModel.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.ViewModel.StoreViewModel.User
{
    public class UserOrderProfile
    {
        public string UserName { get; set; }
        public int Point { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public List<ProductForUserProfile> Product { get; set; }


    }
}
