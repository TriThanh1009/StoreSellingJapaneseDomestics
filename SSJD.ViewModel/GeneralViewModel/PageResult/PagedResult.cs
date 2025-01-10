using SSJD.ViewModel.GeneralViewModel.PageResultBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.ViewModel.GeneralViewModel.PageResult
{
    public class PagedResult<T> :PagingRequestBase
    {
        public List<T> Items { set; get; } = new List<T>();
    }
}
