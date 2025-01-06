using SSJD.ViewModel.GeneralViewModel.PageResultBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.ViewModel.GeneralViewModel.Account
{
    public class AccountPagingRequest : PagingRequestBase
    {
        public string keyword { get; set; } = String.Empty;
    }
}
