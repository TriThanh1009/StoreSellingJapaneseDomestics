using SSJD.ViewModel.GeneralViewModel.PageResultBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.ViewModel.StoreViewModel.Category
{
    public class CategoryPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; } = String.Empty;
    }
}
