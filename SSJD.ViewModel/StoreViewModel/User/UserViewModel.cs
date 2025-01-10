using SSJD.Entities.GeneralEntity;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.ViewModel.StoreViewModel.Customer
{
    public class UserViewModel
    {
        public string Id { get; set; } =  "";
        public string FullName { get; set; } = "";
        public Sex Sex { get; set; } = Sex.Male;
        public string PhoneNumber { get; set; } = "";
        public string Address { get; set; } = "";
        public string IdentityCard { get; set; } = "";
        public string Email { get; set; } = "";
        public string Account { get; set; } = "";
        public string MemberCard { get; set; } = "";

        public string Image { get; set; } = "";
    }
}
