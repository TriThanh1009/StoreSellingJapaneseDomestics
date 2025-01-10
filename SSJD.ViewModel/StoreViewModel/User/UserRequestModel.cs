using Microsoft.AspNetCore.Identity;
using SSJD.Entities.GeneralEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.ViewModel.StoreViewModel.User
{
    public class UserRequestModel : IdentityUser
    {
        
        public string FullName { get; set; } = "";
        public Sex Sex { get; set; } = Sex.Male;
        public string Address { get; set; } = "";
        public string IdentityCard { get; set; } = "";
        public string AccountID { get; set; } = "";
        public string MemberCardID { get; set; } = "";
        public string Image { get; set; } = "";
    }
}
