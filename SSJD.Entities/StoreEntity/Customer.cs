using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSJD.Entities.GeneralEnity;
using SSJD.Entities.GeneralEntity;

namespace SSJD.Entities.StoreEntity
{
    public class Customer
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public Sex Sex { get; set; } = Sex.Male;
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        public string IdentityCard { get; set; }
        public string Email { get; set; }
        public int AccountID { get; set; }
        public int MemberCardID { get; set; }

        public string Image { get; set; }

        public List<Order> Orders { get; set; }

        public Account Account { get; set; } 
        public MemberCard MemberCard { get; set; }

    }
}
