using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using SSJD.Entities.GeneralEnity;
using SSJD.Entities.GeneralEntity;

namespace SSJD.Entities.StoreEntity
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }
        public Sex Sex { get; set; } = Sex.Male;
       // public string PhoneNumeber { get; set; }
        public string Address { get; set; }
        public string IdentityCard { get; set; }
        public string AccountID { get; set; }
        //public string Email { get; set; }
        public string MemberCardID { get; set; }
        public string Image { get; set; }

        public List<Order> Orders { get; set; }
        public Account Account { get; set; } 
        public MemberCard MemberCard { get; set; }

    }
}
