using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.ViewModel.GeneralViewModel.Account
{
    public class AccountRequestModel
    {
        public string ID { get; set; } = "";
        public string UserName { get; set; } = "";
        public string Password { get; set; } = "";
        public string PasswordCheck { get; set; } = "";
        public string Email { get; set; } = "";
    }
}
