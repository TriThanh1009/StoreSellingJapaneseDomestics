using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSJD.Entities.StoreEntity;

namespace SSJD.Entities.GeneralEntity
{
    public class Account
    {
        public string ID { get; set; } = "";
        public string UserName { get; set; } = "";
        public string Password { get; set; } = "";
        public string PasswordCheck { get; set; } = "";
        public string Email { get; set; } = "";

        public User User { get; set; }
    }
}
