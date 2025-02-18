using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.ViewModel.StoreViewModel.Login
{
    public class LoginRequestModel
    {
        public string ID { get; set; }
        public string UserID { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string accessToken { get; set; }
    }
}
