using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSJD.Entities.EmployeeEntity;
using SSJD.Entities.StoreEntity;

namespace SSJD.Entities.GeneralEnity
{
    public class Account
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PasswordCheck { get; set; }
        public string Email { get; set; }

        public Customer Customer { get; set; }
        public Employee Employee { get; set; } 
    }
}
