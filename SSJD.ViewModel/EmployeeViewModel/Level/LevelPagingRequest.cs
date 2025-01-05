using SSJD.ViewModel.GeneralViewModel.PageResultBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.ViewModel.EmployeeViewModel.Level
{
    public class LevelPagingRequest : PagingRequestBase
    {
        public string keyword { get; set; } = String.Empty;
    }
}
